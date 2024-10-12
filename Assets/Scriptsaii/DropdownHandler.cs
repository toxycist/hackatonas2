using UnityEngine;
using UnityEngine.UI;

public class DropdownHandler : MonoBehaviour
{
    public Dropdown dropdown;  // Reference to the dropdown

    void Start()
    {
        // Add a listener to detect when a different dropdown option is selected
        dropdown.onValueChanged.AddListener(OnDropdownValueChanged);
    }

    // This method is called when the dropdown value is changed
    public void OnDropdownValueChanged(int index)
    {
        
        switch (index)
        {
            case 0:
                // Action for option 1
                Debug.Log("First option selected, do something!");
                break;
            case 1:
                // Action for option 2
                Debug.Log("Second option selected, do something else!");
                break;
            case 2:
                // Action for option 3
                Debug.Log("Third option selected, perform another action!");
                break;
            default:
                Debug.Log("Another option selected");
                break;
        }
    }
}
