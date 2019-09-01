using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    private Rigidbody ball;
    public float speed;

    private void Awake()
    {
        ball = GetComponent<Rigidbody>();
    }
    

    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");// горизонтальное перемещение
        float moveVertical = Input.GetAxis("Vertical");// вертикальное перемещение 

        ball.velocity = new Vector3(moveHorizontal, 0, moveVertical) * speed; // движение и скорость движение

        /*float xPosition = Mathf.Clamp(ball.position.x, xmin, xmax);// вращение по осм х
        float zPosition = Mathf.Clamp(ball.position.z, zmin, zmax);// вращение по оси z 

        ball.position = new Vector3(xPosition, 0, zPosition);// истиное перемещение 
        
        ball.rotation = Quaternion.Euler(ball.velocity.z * tilt, 0, -ball.velocity.x * tilt);// истиное вращение*/
    }
}
