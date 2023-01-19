using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Poschodia : MonoBehaviour
{
    [SerializeField] Kamera kamera;
    [SerializeField] Transform poschodie_1;
    [SerializeField] Transform poschodie0;
    [SerializeField] Transform poschodie1;
    [SerializeField] Transform poschodie2;
    [SerializeField] Transform poschodie3;
    [SerializeField] Transform poschodie4;
    int AktualnePoschodie = 2;
    [SerializeField] Image Button_1;
    [SerializeField] Image Button0;
    [SerializeField] Image Button1;
    [SerializeField] Image Button2;
    [SerializeField] Image Button3;
    [SerializeField] Image Button4;
    [SerializeField] Sprite Button_default_1;
    [SerializeField] Sprite Button_default0;
    [SerializeField] Sprite Button_default1;
    [SerializeField] Sprite Button_default2;
    [SerializeField] Sprite Button_default3;
    [SerializeField] Sprite Button_default4;
    [SerializeField] Sprite Button_pressed_1;
    [SerializeField] Sprite Button_pressed0;
    [SerializeField] Sprite Button_pressed1;
    [SerializeField] Sprite Button_pressed2;
    [SerializeField] Sprite Button_pressed3;
    [SerializeField] Sprite Button_pressed4;
    public void Poschodie1()
    {
        if(AktualnePoschodie!=1)
        {
            Camera.main.transform.position = poschodie1.position;
            kamera.MinY = -126;
            kamera.MaxY = -74;
            kamera.MinX = -42;
            kamera.MaxX = 42;
            kamera.ResetPos = poschodie1;
            AktualnePoschodie = 1;
            Button_1.sprite = Button_default_1;
            Button0.sprite = Button_default0;
            Button1.sprite = Button_pressed1;
            Button2.sprite = Button_default2;
            Button3.sprite = Button_default3;
            Button4.sprite = Button_default4;
        }
    }
    public void Poschodie2()
    {
        if (AktualnePoschodie!=2)
        {
            Camera.main.transform.position = poschodie2.position;
            kamera.MinY = -26;
            kamera.MaxY = 26;
            kamera.MinX = -42;
            kamera.MaxX = 42;
            kamera.ResetPos = poschodie2;
            AktualnePoschodie = 2;
            Button_1.sprite = Button_default_1;
            Button0.sprite = Button_default0;
            Button1.sprite = Button_default1;
            Button2.sprite = Button_pressed2;
            Button3.sprite = Button_default3;
            Button4.sprite = Button_default4;
        }       
    }
    public void Poschodie0()
    {
        if (AktualnePoschodie != 0)
        {
            Camera.main.transform.position = poschodie0.position;
            kamera.MinY = -226;
            kamera.MaxY = -174;
            kamera.MinX = -42;
            kamera.MaxX = 42;
            kamera.ResetPos = poschodie0;
            AktualnePoschodie = 0;
            Button_1.sprite = Button_default_1;
            Button0.sprite = Button_pressed0;
            Button1.sprite = Button_default1;
            Button2.sprite = Button_default2;
            Button3.sprite = Button_default3;
            Button4.sprite = Button_default4;
        }
    }
    public void Poschodie_1()
    {
        if (AktualnePoschodie != -1)
        {
            Camera.main.transform.position = poschodie_1.position;
            kamera.MinY = -326;
            kamera.MaxY = -274;
            kamera.MinX = -42;
            kamera.MaxX = 42;
            kamera.ResetPos = poschodie_1;
            AktualnePoschodie = -1;
            Button_1.sprite = Button_pressed_1;
            Button0.sprite = Button_default0;
            Button1.sprite = Button_default1;
            Button2.sprite = Button_default2;
            Button3.sprite = Button_default3;
            Button4.sprite = Button_default4;
        }
    }
    public void Poschodie3()
    {
        if (AktualnePoschodie != 3)
        {
            Camera.main.transform.position = poschodie3.position;
            kamera.MinY = -120;
            kamera.MaxY = -80;
            kamera.MinX = 175;
            kamera.MaxX = 225;
            kamera.ResetPos = poschodie3;
            AktualnePoschodie = 3;
            Button_1.sprite = Button_default_1;
            Button0.sprite = Button_default0;
            Button1.sprite = Button_default1;
            Button2.sprite = Button_default2;
            Button3.sprite = Button_pressed3;
            Button4.sprite = Button_default4;
        }
    }
    public void Poschodie4()
    {
        if (AktualnePoschodie != 4)
        {
            Camera.main.transform.position = poschodie4.position;
            kamera.MinY = -20;
            kamera.MaxY = 20;
            kamera.MinX = 175;
            kamera.MaxX = 225;
            kamera.ResetPos = poschodie4;
            AktualnePoschodie = 4;
            Button_1.sprite = Button_default_1;
            Button0.sprite = Button_default0;
            Button1.sprite = Button_default1;
            Button2.sprite = Button_default2;
            Button3.sprite = Button_default3;
            Button4.sprite = Button_pressed4;
        }
    }
}
