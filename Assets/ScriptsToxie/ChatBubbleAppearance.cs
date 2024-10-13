using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChatBubbleAppearance : MonoBehaviour
{
    public static ChatBubbleAppearance Instance { get; private set; }
    public int frazesk;
    public bool windowFound = false;
    private void Awake()
    {
        // Check if the instance already exists
        if (Instance != null && Instance != this)
        {
            // If another instance exists, destroy this one to enforce singleton pattern
            Destroy(gameObject);
            return;
        }

        // Assign the instance to this object
        Instance = this;

        // Optionally, make the singleton persistent across scenes
        DontDestroyOnLoad(gameObject);
    }

    [SerializeField] GameObject ChatBubble;
    // Start is called before the first frame update
    public void Show()
    {
        ChatBubble.SetActive(true);
    }

    public void Hide()
    {
        ChatBubble.SetActive(false);
    }
}
