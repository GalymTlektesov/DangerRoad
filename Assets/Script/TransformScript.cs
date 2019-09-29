using UnityEngine;

public class TransformScript : MonoBehaviour
{
    public Transform ball;
    private Rigidbody simulate;

    void Start()
    {
        simulate = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if(simulate.position != ball.position)
        {
            simulate.position = ball.position;
        }
    }
}
