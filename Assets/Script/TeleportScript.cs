using System;
using UnityEngine;

public class TeleportScript : MonoBehaviour
{
    public TeleportScript teleport;

    private float PosX, PosY, PosZ;
   

    private void Start()
    {
        PosX = teleport.transform.position.x;
        PosZ = teleport.transform.position.z;
        PosY = teleport.transform.position.y;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ball"))
        {
            var ball = other.GetComponent<BallController>();
            if (!ball.IsTeleport)
            {
                ball.IsTeleport = true;
                var ScaleY = ball.transform.lossyScale.y;
                other.transform.position = new Vector3(PosX, PosY + ScaleY, PosZ);
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Ball"))
        {
            var ball = other.GetComponent<BallController>();
            ball.IsTeleport = true;
        }
    }
}
