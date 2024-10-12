using System;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

public class FileMonitor : MonoBehaviour
{
    public RectTransform rectangle; // UI rectangle to display
    public string windowTitle = "Browser.txt - Notepad"; // Title of the window to detect (change as needed)

    [DllImport("user32.dll", SetLastError = true)]
    static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

    [DllImport("user32.dll", SetLastError = true)]
    static extern bool GetWindowRect(IntPtr hWnd, out RECT lpRect);

    [DllImport("user32.dll")]
    static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

    [StructLayout(LayoutKind.Sequential)]
    public struct RECT
    {
        public int Left;
        public int Top;
        public int Right;
        public int Bottom;
    }

    public IntPtr hWnd;

    void Start()
    {
        // Hide the rectangle initially
        rectangle.gameObject.SetActive(false);
    }

    void Update()
    {
        // Find the window by its title
        hWnd = FindWindow(null, windowTitle);
        if (hWnd != IntPtr.Zero)
        {
            ShowWindow(hWnd, 0);
            // Get the window's dimensions
            RECT windowRect;
            if (GetWindowRect(hWnd, out windowRect))
            {
                // Calculate width and height of the window
                int width = windowRect.Right - windowRect.Left;
                int height = windowRect.Bottom - windowRect.Top;

                // Calculate the position (screen coordinates)
                Vector3 screenPosition = new Vector3(windowRect.Left, Screen.height - windowRect.Top, 0);

                // Render and position the rectangle in Unity with the same size and position as the window
                RenderRectangle(width, height, screenPosition);
            }
            else
            {
                rectangle.gameObject.SetActive(false); // Hide if the window cannot be retrieved
            }
        }
        else
        {
            rectangle.gameObject.SetActive(false); // Hide if the window is not found
        }
    }

    void RenderRectangle(int width, int height, Vector3 position)
    {
        // Activate and resize the rectangle based on the window size
        rectangle.gameObject.SetActive(true);
        rectangle.sizeDelta = new Vector2(width, height);

        // Convert the screen position to the canvas space
        Vector2 anchoredPosition;
        RectTransformUtility.ScreenPointToLocalPointInRectangle(
            rectangle.parent.GetComponent<RectTransform>(), // Get the parent RectTransform
            position,
            null, // Use the current event camera
            out anchoredPosition
        );

        // Set the position of the rectangle
        rectangle.anchoredPosition = new Vector2(anchoredPosition.x-10, anchoredPosition.y);
    }
}