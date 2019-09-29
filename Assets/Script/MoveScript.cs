using UnityEngine;

public class MoveScript : MonoBehaviour
{
    public Rigidbody ball;
    public float speed;
    public float speedRotate;

    private bool Up;
    private bool Down;
    void Awake()
    {

        ball = GetComponent<Rigidbody>();
    }

    void Update()
    {
        var xRote = ball.rotation.x;
        var yRote = ball.rotation.y;
        var zRote = ball.rotation.z;
        if (Up)
        {
            ball.AddForce(transform.forward * speed);
            ball.rotation = Quaternion.Euler(xRote, yRote + speedRotate * Time.deltaTime, zRote);
        }
        if(Down)
        {
            ball.AddForce(transform.forward * -speed);
        }
    }
    public void UpMoveDown()
    {
        Up = true;
    }

    public void UpMoveUp()
    {
        Up = false;
    }

    public void DownMoveDown()
    {
        Down = true;
    }

    public void DownMoveUp()
    {
        Down = false;
    }
}
