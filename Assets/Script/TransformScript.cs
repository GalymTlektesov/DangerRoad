using UnityEngine;

public class TransformScript : MonoBehaviour
{
    public Transform ball;
    private Rigidbody simulate;

    private float rotY;

    public float speedRotation;

    void Start()
    {
        simulate = GetComponent<Rigidbody>();
        rotY = simulate.rotation.y;
    }

    void Update()
    {
        simulate.position = ball.position;
    }

    void FixedUpdate()
    {
        var rotation = simulate.rotation;

        if (Input.GetKeyDown(KeyCode.A))
        {
            rotY += 90;
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            rotY -= 90;
        }
        simulate.rotation = Quaternion.Lerp(rotation, Quaternion.Euler(0, rotY, 0), speedRotation * Time.deltaTime);
    }
}
