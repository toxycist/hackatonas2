using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TabChanger : MonoBehaviour
{
    public GameObject menu;
    public GameObject mainPanel; 
    public GameObject mailPanel; 
    public GameObject messPanel; 
    public GameObject torrPanel; 
    public GameObject button1;
    public GameObject button2;
    public GameObject button3;
    public GameObject button4;
    RectTransform tr1;
    RectTransform tr2;
    RectTransform tr3;
    RectTransform tr4;
    void Start()
    {
    tr1 = button1.GetComponent<RectTransform>();
    tr2 = button2.GetComponent<RectTransform>();
    tr3 = button3.GetComponent<RectTransform>();
    tr4 = button4.GetComponent<RectTransform>();
    }
    public void MainTab() 
    {
        tr1.anchoredPosition  = new Vector2(tr1.anchoredPosition.x, -20f);
        tr2.anchoredPosition  = new Vector2(tr2.anchoredPosition.x, -25f);
        tr3.anchoredPosition  = new Vector2(tr3.anchoredPosition.x, -25f);
        tr4.anchoredPosition  = new Vector2(tr4.anchoredPosition.x, -25f);
        mainPanel.SetActive(true);
        mailPanel.SetActive(false);
        messPanel.SetActive(false);
        torrPanel.SetActive(false);
    }
    public void MailTab()
    {
        tr1.anchoredPosition  = new Vector2(tr1.anchoredPosition.x, -25f);
        tr2.anchoredPosition  = new Vector2(tr2.anchoredPosition.x, -20f);
        tr3.anchoredPosition  = new Vector2(tr3.anchoredPosition.x, -25f);
        tr4.anchoredPosition  = new Vector2(tr4.anchoredPosition.x, -25f);
        mainPanel.SetActive(false);
        mailPanel.SetActive(true);
        messPanel.SetActive(false);
        torrPanel.SetActive(false);
    }
    public void MessTab()
    {
        tr1.anchoredPosition  = new Vector2(tr1.anchoredPosition.x, -25f);
        tr2.anchoredPosition  = new Vector2(tr2.anchoredPosition.x, -25f);
        tr3.anchoredPosition  = new Vector2(tr3.anchoredPosition.x, -20f);
        tr4.anchoredPosition  = new Vector2(tr4.anchoredPosition.x, -25f);
        mainPanel.SetActive(false);
        mailPanel.SetActive(false);
        messPanel.SetActive(true);
        torrPanel.SetActive(false);
    }
    public void TorrTab()
    {
        tr1.anchoredPosition  = new Vector2(tr1.anchoredPosition.x, -25f);
        tr2.anchoredPosition  = new Vector2(tr2.anchoredPosition.x, -25f);
        tr3.anchoredPosition  = new Vector2(tr3.anchoredPosition.x, -25f);
        tr4.anchoredPosition  = new Vector2(tr4.anchoredPosition.x, -20f);
        mainPanel.SetActive(false);
        mailPanel.SetActive(false);
        messPanel.SetActive(false);
        torrPanel.SetActive(true);
    }
    public void Close()
    {
        menu.SetActive(false);
    }
}
