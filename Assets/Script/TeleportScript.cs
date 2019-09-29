using System.Collections.Generic;
using UnityEngine;

public class TeleportScript : MonoBehaviour
{
    public TeleportScript teleport;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ball"))
        {
            var PosX = teleport.transform.position.x;
            var PosZ = teleport.transform.position.z;
            var PosY = teleport.transform.position.y;
            var ScaleSY = other.transform.lossyScale.y;

            var ball = other.GetComponent<BallController>();
            if (!ball.IsTeleport)
            {
                ball.IsTeleport = true;
                Debug.Log(other.name);
                other.transform.position = new Vector3(PosX, PosY + ScaleSY, PosZ);
            }
        }
    }
}
