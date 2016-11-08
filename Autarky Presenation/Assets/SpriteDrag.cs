using UnityEngine;
using System.Collections;

[RequireComponent(typeof(BoxCollider2D))]

public class SpriteDrag : MonoBehaviour
{
    private Vector3 screenPoint;
    private Vector3 offset;
    private Vector3 grabbedScale = new Vector3(0.3f,0.3f,1f);
    private Vector3 startScale;

    void Start()
    {
        startScale = transform.localScale;
    }

    void OnMouseDown()
    {

        offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));
        transform.localScale = grabbedScale;
    }

    void OnMouseDrag()
    {
        Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
        Vector3 curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint) + offset;
        transform.position = curPosition;
    }

    void OnMouseUp()
    {
        transform.localScale = startScale;
    }
}