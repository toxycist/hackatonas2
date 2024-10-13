using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScenarijusHamletasSheakspearas : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Scenarij());
    }

    IEnumerator Scenarij()
    {
        ChatBubbleAppearance.Instance.frazesk = 1;
        Debug.Log("frazesk=1");
        ChatBubbleAppearance.Instance.Show();
        Debug.Log("showed, waiting");
        yield return new WaitForSeconds(5);
        Debug.Log("waited");
        ChatBubbleAppearance.Instance.Hide();
        Debug.Log("hidden");

        ChatBubbleAppearance.Instance.frazesk++;
        FileCreate fileCreate = new FileCreate();
        fileCreate.CreateFile();
        yield return new WaitForSeconds(1);
        ChatBubbleAppearance.Instance.Show();
        yield return new WaitForSeconds(6);
        ChatBubbleAppearance.Instance.Hide();

        yield return new WaitForSeconds(1);
        ChatBubbleAppearance.Instance.frazesk++;
        ChatBubbleAppearance.Instance.Show();
        yield return new WaitForSeconds(6);
        ChatBubbleAppearance.Instance.frazesk++;
        // atejo laiskas
        yield return new WaitForSeconds(6);
        ChatBubbleAppearance.Instance.frazesk++; //ei, perskaitei?
        yield return new WaitForSeconds(3);
        ChatBubbleAppearance.Instance.frazesk++;
        yield return new WaitForSeconds(6);
        ChatBubbleAppearance.Instance.frazesk++;
        yield return new WaitForSeconds(6);
        ChatBubbleAppearance.Instance.frazesk++;
        yield return new WaitForSeconds(6);
        ChatBubbleAppearance.Instance.frazesk++; // pranesimo message
        //laisko ciklas baigtas


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
