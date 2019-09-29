using UnityEngine;

public class MotionScript : MonoBehaviour
{
    public float speed;
    private Transform transform;
    private float Y;
    private float newY;

    void Start()
    {
        transform = GetComponent<Transform>();
        Y = transform.position.y;
        newY = Y - 60;
    }

    void Update()
    {
        var position = transform.position;
        transform.position = Vector3.MoveTowards(position, new Vector3(position.x, newY, position.z), speed * Time.deltaTime);
        if (transform.position.y == newY)
        {
            Destroy(gameObject);
        }
    }
}
