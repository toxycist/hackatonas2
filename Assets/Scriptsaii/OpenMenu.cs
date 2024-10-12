using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenMenu : MonoBehaviour
{
    public GameObject Menu;

    public void Open()
    {
        Menu.SetActive(true);
    }
}
