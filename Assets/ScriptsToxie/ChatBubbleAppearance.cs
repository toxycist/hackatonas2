using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChatBubbleAppearance : MonoBehaviour
{
    [SerializeField] GameObject ChatBubble;
    // Start is called before the first frame update
    void Show()
    {
        ChatBubble.SetActive(true);
    }

    void Hide()
    {
        ChatBubble.SetActive(false);
    }
}
