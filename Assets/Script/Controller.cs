using UnityEngine;

public class Controller : MonoBehaviour
{
    public Rigidbody player;
    private Transform jostic;

    private void Start() 
    {
        jostic = GetComponent<Transform>();
    }

    private void OnMouseDrag()
    {
        var mousPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousPos.x = mousPos.x > 0.047f ? 0.047f : mousPos.x;
        mousPos.x = mousPos.x < -0.047f ? -0.047f : mousPos.x;
        mousPos.y = mousPos.y > 0.045f ? 0.045f : mousPos.y;
        mousPos.y = mousPos.y < -0.045f ? -0.045f : mousPos.y;
        jostic.localPosition = Vector3.MoveTowards(jostic.localPosition, new Vector3(mousPos.x, mousPos.y, jostic.localPosition.z), 200);
    }
}
