using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Messenger : MonoBehaviour
{
    public GameObject chat1;
    public GameObject chat2;
    public GameObject chat3;
    public GameObject chat4;
    public GameObject chat5;
    public GameObject userButton1;
    public GameObject userButton2;
    public GameObject userButton3;
    public GameObject userButton4;
    public GameObject userButton5;
    RectTransform tr1;
    RectTransform tr2;
    RectTransform tr3;
    RectTransform tr4;
    RectTransform tr5;
    Image buttonImage1;
    Image buttonImage2;
    Image buttonImage3;
    Image buttonImage4;
    Image buttonImage5;
    public Color newColor = Color.gray;
    public Color oldColor = Color.white;

    void Start()
    {
        buttonImage1 = userButton1.GetComponent<Image>();
        buttonImage2 = userButton2.GetComponent<Image>();
        buttonImage3 = userButton3.GetComponent<Image>();
        buttonImage4 = userButton4.GetComponent<Image>();
        buttonImage5 = userButton5.GetComponent<Image>();
        tr1 = userButton1.GetComponent<RectTransform>();
        tr2 = userButton2.GetComponent<RectTransform>();
        tr3 = userButton3.GetComponent<RectTransform>();
        tr4 = userButton4.GetComponent<RectTransform>();
        tr5 = userButton5.GetComponent<RectTransform>();
    }

    public void User1()
    {
        buttonImage1.color = newColor;
        buttonImage2.color = oldColor;
        buttonImage3.color = oldColor;
        buttonImage4.color = oldColor;
        buttonImage5.color = oldColor;
        chat1.SetActive(true);
        chat2.SetActive(false);
        chat3.SetActive(false);
        chat4.SetActive(false);
        chat5.SetActive(false);
    }
    public void User2()
    {
        buttonImage1.color = oldColor;
        buttonImage2.color = newColor;
        buttonImage3.color = oldColor;
        buttonImage4.color = oldColor;
        buttonImage5.color = oldColor;
        chat1.SetActive(false);
        chat2.SetActive(true);
        chat3.SetActive(false);
        chat4.SetActive(false);
        chat5.SetActive(false);
    }
    public void User3()
    {
        buttonImage1.color = oldColor;
        buttonImage2.color = oldColor;
        buttonImage3.color = newColor;
        buttonImage4.color = oldColor;
        buttonImage5.color = oldColor;
        chat1.SetActive(false);
        chat2.SetActive(false);
        chat3.SetActive(true);
        chat4.SetActive(false);
        chat5.SetActive(false);
    }
    public void User4()
    {
        buttonImage1.color = oldColor;
        buttonImage2.color = oldColor;
        buttonImage3.color = oldColor;
        buttonImage4.color = newColor;
        buttonImage5.color = oldColor;
        chat1.SetActive(false);
        chat2.SetActive(false)
        chat3.SetActive(false);
        chat4.SetActive(true);
        chat5.SetActive(false);
    }
    public void User5()
    {
        buttonImage1.color = oldColor;
        buttonImage2.color = oldColor;
        buttonImage3.color = oldColor;
        buttonImage4.color = oldColor;
        buttonImage5.color = newColor;
        chat1.SetActive(false);
        chat2.SetActive(false);
        chat3.SetActive(false);
        chat4.SetActive(false);
        chat5.SetActive(true);
    }
}
