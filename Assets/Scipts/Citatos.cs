using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Citatos : MonoBehaviour
{
    private TMP_Text myText;
    int frazesk = 0;
    void Start()
    {
        myText = GetComponent<TMP_Text>();
    }
    void Update()
    { 
        if(frazesk == 0 && Input.GetKeyDown(KeyCode.Space))
        {
            myText.text = "Amogus ateik cia";
            frazesk++;
        }
    }
}
