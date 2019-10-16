using UnityEngine;

public class MoveScript : MonoBehaviour
{
    public Rigidbody ball;
    public float speed;
    public float speedRotate;

    private Animator anim;
    private bool Up;
    private bool Down;
    void Awake()
    {
        anim = GetComponent<Animator>();
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
            ball.rotation = Quaternion.Lerp(ball.rotation, Quaternion.Euler(++xRote, yRote, zRote), speedRotate * Time.deltaTime);
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
