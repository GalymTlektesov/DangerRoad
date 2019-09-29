using UnityEngine;
using UnityEngine.EventSystems;

public class RotateScript : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    public Transform[] ball;
    private float rotY;

    public float speedRotation = 2;

    void Awake()
    {
        for (int i = 0; i < ball.Length; i++)
        {
            rotY = ball[i].rotation.y;
        }
    }
    public void OnBeginDrag(PointerEventData eventData)
    {
    }

    public void OnDrag(PointerEventData eventData)
    {
        
    }

    void Update()
    {
        for (int i = 0; i < ball.Length; i++)
        {
            ball[i].rotation = Quaternion.Lerp(ball[i].rotation, Quaternion.Euler(0, rotY, 0), Time.deltaTime * speedRotation);
        }
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        if((Mathf.Abs(eventData.delta.x)) > (Mathf.Abs(eventData.delta.y)))
        {
            if (eventData.delta.x > 0)
            {
                rotY += 90;
            }
            else
            {
                rotY -= 90;
            }
        }
    }
}
