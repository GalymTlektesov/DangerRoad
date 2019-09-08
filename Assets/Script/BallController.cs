using UnityEngine;

public class BallController : MonoBehaviour
{
    private Rigidbody ball;
    public float speed;
    public float jumpForce;

    public float speedRotation;

    public bool IsTeleport = true;

    private float rotY;

    private void Awake() 
    {
        ball = GetComponent<Rigidbody>();
        rotY = ball.rotation.y;
    }

    private void FixedUpdate()
    {
        var rotation = ball.rotation; 

        //ball.velocity = new Vector3(moveHorizontal, -28, moveVertical) * speed; // движение и скорость движение

        if(Input.GetButton("Jump"))
        {
            ball.AddForce(transform.up * jumpForce, ForceMode.Impulse);
        }

        if(Input.GetKey(KeyCode.W)) { ball.AddForce(transform.forward * speed, ForceMode.VelocityChange); }
        if(Input.GetKey(KeyCode.S)) { ball.AddForce(transform.forward * -speed, ForceMode.VelocityChange); }

        if (Input.GetKeyDown(KeyCode.A))
        {
            rotY += 90;
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            rotY -= 90;
        }
        ball.rotation = Quaternion.Lerp(rotation, Quaternion.Euler(rotation.x, rotY, rotation.z), speedRotation * Time.deltaTime);
    }
}
