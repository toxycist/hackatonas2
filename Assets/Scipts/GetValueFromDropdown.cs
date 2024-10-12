using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class GetValueFromDropdown : MonoBehaviour
{
    [SerializeField] private TMP_Dropdown dropdown;
    public void GetDropdownValue()
    {
        int pickedEntryIndex = dropdown.value;
        //string selectedOption = dropdown.options[pickedEntryIndex].text; 
        Debug.Log(pickedEntryIndex);
    }


}
