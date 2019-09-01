using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    public Transform ball;
    private Transform camera;
    void Start()
    {
        camera = GetComponent<Transform>();
    }


    void Update()
    {
        camera.position = new Vector3(0, ball.position.y + 160, ball.position.z - 403);
    }
}
