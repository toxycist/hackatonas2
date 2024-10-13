using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenThat : MonoBehaviour
{

    public GameObject panel;
    public GameObject image;
    private void Start()
    {
        image.SetActive(true);
    }

    public void ActivateScript()
    {
        panel.SetActive(true);
        image.SetActive(false);
    }

    public void Deactivate()
    {
        panel.SetActive(false);
    }
}
