using UnityEngine;

public class TeleportScript : MonoBehaviour
{
    public TeleportScript teleport;

    private void OnCollisionEnter(Collision other) 
    {
        if (other.collider.CompareTag("Ball"))
        {
            var ball = other.collider.GetComponent<BallController>();
            if (!ball.IsTeleport)
            {
                var PosX = teleport.transform.position.x;
                var PosZ = teleport.transform.position.z;
                var PosY = other.transform.position.y;
                other.transform.position = new Vector3(PosX, PosY, PosZ);
            }
            ball.IsTeleport = true;
        }
    }
}
