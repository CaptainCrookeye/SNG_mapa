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
    int AktualnePoschodie = 0;
    public void Poschodie1()
    {
        if(AktualnePoschodie!=1 && !Kamera.IsMoving)
        {
            Camera.main.transform.position = poschodie1.position;
            Kamera.CanMove = true;
            kamera.ResetPos = poschodie1;
            AktualnePoschodie = 1;
            Button_1.sprite = Button_default_1;
            Button0.sprite = Button_default0;
            Button1.sprite = Button_pressed1;
            Button2.sprite = Button_default2;
            Button3.sprite = Button_default3;
            Button4.sprite = Button_default4;
            Camera.main.transform.position = kamera.ResetPos.position;
        }
    }
    public void Poschodie2()
    {
        if (AktualnePoschodie!=2 && !Kamera.IsMoving)
        {
            Camera.main.transform.position = poschodie2.position;
            Kamera.CanMove = true;
            kamera.ResetPos = poschodie2;
            AktualnePoschodie = 2;
            Button_1.sprite = Button_default_1;
            Button0.sprite = Button_default0;
            Button1.sprite = Button_default1;
            Button2.sprite = Button_pressed2;
            Button3.sprite = Button_default3;
            Button4.sprite = Button_default4;
            Camera.main.transform.position = kamera.ResetPos.position;
        }       
    }
    public void Poschodie0()
    {
        if (AktualnePoschodie != 0 && !Kamera.IsMoving)
        {
            Camera.main.transform.position = poschodie0.position;
            Kamera.CanMove = true;
            kamera.ResetPos = poschodie0;
            AktualnePoschodie = 0;
            Button_1.sprite = Button_default_1;
            Button0.sprite = Button_pressed0;
            Button1.sprite = Button_default1;
            Button2.sprite = Button_default2;
            Button3.sprite = Button_default3;
            Button4.sprite = Button_default4;
            Camera.main.transform.position = kamera.ResetPos.position;
        }
    }
    public void Poschodie_1()
    {
        if (AktualnePoschodie != -1 && !Kamera.IsMoving)
        {
            Camera.main.transform.position = poschodie_1.position;
            Kamera.CanMove = true;
            kamera.ResetPos = poschodie_1;
            AktualnePoschodie = -1;
            Button_1.sprite = Button_pressed_1;
            Button0.sprite = Button_default0;
            Button1.sprite = Button_default1;
            Button2.sprite = Button_default2;
            Button3.sprite = Button_default3;
            Button4.sprite = Button_default4;
            Camera.main.transform.position = kamera.ResetPos.position;
        }
    }
    public void Poschodie3()
    {
        if (AktualnePoschodie != 3 && !Kamera.IsMoving)
        {
            Camera.main.transform.position = poschodie3.position;
            Kamera.CanMove = true;
            kamera.ResetPos = poschodie3;
            AktualnePoschodie = 3;
            Button_1.sprite = Button_default_1;
            Button0.sprite = Button_default0;
            Button1.sprite = Button_default1;
            Button2.sprite = Button_default2;
            Button3.sprite = Button_pressed3;
            Button4.sprite = Button_default4;
            Camera.main.transform.position = kamera.ResetPos.position;
        }
    }
    public void Poschodie4()
    {
        if (AktualnePoschodie != 4 && !Kamera.IsMoving)
        {
            Camera.main.transform.position = poschodie4.position;
            Kamera.CanMove = true;
            kamera.ResetPos = poschodie4;
            AktualnePoschodie = 4;
            Button_1.sprite = Button_default_1;
            Button0.sprite = Button_default0;
            Button1.sprite = Button_default1;
            Button2.sprite = Button_default2;
            Button3.sprite = Button_default3;
            Button4.sprite = Button_pressed4;
            Camera.main.transform.position = kamera.ResetPos.position;
        }
    }
}
