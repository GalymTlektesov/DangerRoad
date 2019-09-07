using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    public Transform ball;
    private Transform camera;
    private float rotY;

    public float speedRotation;
    void Start()
    {
        rotY = camera.rotation.y;
        camera = GetComponent<Transform>();
    }


    void Update()
    {
        //camera.localPosition = new Vector3(0, 1.62f, ball.position.z - 403);
        camera.rotation = Quaternion.Euler(20, rotY, 0);
    }
}
