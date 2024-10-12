using System;
using System.Runtime.InteropServices;
using UnityEngine;

public class TransparentWindow : MonoBehaviour
{
#if !UNITY_EDITOR
    [DllImport("user32.dll")]
    static extern IntPtr GetActiveWindow();

    [DllImport("user32.dll")]
    static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);

    [DllImport("user32.dll")]
    static extern int GetWindowLong(IntPtr hWnd, int nIndex);

    [DllImport("user32.dll")]
    static extern bool SetLayeredWindowAttributes(IntPtr hwnd, uint crKey, byte bAlpha, uint dwFlags);

    [DllImport("user32.dll")]
    static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, uint uFlags);

    const int GWL_EXSTYLE = -20;
    const int WS_EX_LAYERED = 0x80000;
    const int HWND_TOPMOST = -1; // Value for topmost window
    const int SWP_NOSIZE = 0x0001; // Do not change size
    const int SWP_NOMOVE = 0x0002; // Do not change position
    const int LWA_COLORKEY = 0x1;
    const int LWA_ALPHA = 0x2;
#endif

    void Start()
    {
#if !UNITY_EDITOR
        IntPtr hwnd = GetActiveWindow();
        // Make window layered but not input-transparent
        SetWindowLong(hwnd, GWL_EXSTYLE, GetWindowLong(hwnd, GWL_EXSTYLE) | WS_EX_LAYERED);

        // Adjust color key and alpha for selective transparency
        SetLayeredWindowAttributes(hwnd, 0, 255, LWA_COLORKEY); // 255 means fully opaque

        // Set the window as topmost
        SetWindowPos(hwnd, (IntPtr)HWND_TOPMOST, 0, 0, 0, 0, SWP_NOSIZE | SWP_NOMOVE);
#endif
    }
}