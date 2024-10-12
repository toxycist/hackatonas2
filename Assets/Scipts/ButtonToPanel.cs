using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonToPanel : MonoBehaviour
{

    public GameObject panel;
    public Button butan;

    void Start()
    {
        butan.onClick.AddListener(TaskExecute);
    }

void TaskExecute()
    {
        Debug.Log("help");
    }
}
