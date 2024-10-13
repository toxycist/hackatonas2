using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionTheodoreAsAWhole : MonoBehaviour
{
    [SerializeField] GameObject ChatBubble;
    [SerializeField] GameObject TheodoreHandLeft;
    [SerializeField] GameObject TheodoreHandRight;
    [SerializeField] float speed = 0.1f;       // Speed of the up/down movement
    [SerializeField] float distance = 0.5f;  // The distance to move up and down

    void Update()
    {
        // Calculate the vertical oscillation for the hands
        float offsetY = Mathf.PingPong(Time.time * speed, distance * 2) - distance;

        // Set the hands' positions relative to Theodore's current position, applying vertical movement
        TheodoreHandRight.transform.position = new Vector3(transform.position.x + 0.85f, transform.position.y + offsetY, transform.position.z);
        TheodoreHandLeft.transform.position = new Vector3(transform.position.x - 0.85f, transform.position.y + offsetY, transform.position.z);
        ChatBubble.transform.position = new Vector3(transform.position.x - 1.75f, transform.position.y + 3.5f, transform.position.z);
    }
}