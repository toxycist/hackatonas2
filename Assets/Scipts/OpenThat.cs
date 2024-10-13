using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenThat : MonoBehaviour
{

    public GameObject panel;

    public void ActivateScript()
    {
        panel.SetActive(true);
    }

    public void Deactivate()
    {
        panel.SetActive(false);
    }
}
