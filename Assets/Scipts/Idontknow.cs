using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Idontknow : MonoBehaviour
{
    public GameObject panel;
    public Button butan;

    private void Update()
    {
        butan.onClick.AddListener(TaskExecute);
    }

    void TaskExecute()
    {
        Debug.Log("help");
    }
}
