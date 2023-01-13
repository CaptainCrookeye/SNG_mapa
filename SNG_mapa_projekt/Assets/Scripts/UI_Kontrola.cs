using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UI_Kontrola : MonoBehaviour
{
    [SerializeField] GameObject Despawnable;
    [SerializeField] Image image;
    [SerializeField] Sprite Button_default;
    [SerializeField] Sprite Button_pressed;
    bool UI = true;
    bool instance = true;
    void Update()
    {
        if(!Triedy.control && UI)
        {
            Despawnable.SetActive(true);
        }
        else
        {
            Despawnable.SetActive(false);
        }
    }
    public void UIswitch()
    {
        if (!instance)
        {
            UI = true;
            image.sprite = Button_pressed;
            instance = true;
        }         
        else
        {
            UI = false;
            image.sprite = Button_default;
            instance = false;
        }            
    }
}
