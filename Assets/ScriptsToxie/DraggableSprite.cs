using UnityEngine;

public class DraggableSprite : MonoBehaviour
{
    private bool isDragging = false;

    void OnMouseDown()
    {
        isDragging = true;
    }

    void OnMouseDrag()
    {
        if (isDragging)
        {
            Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            mousePosition.z = 0; // Keep z-axis constant
            transform.position = mousePosition;
        }
    }

    void OnMouseUp()
    {
        isDragging = false;
    }
}