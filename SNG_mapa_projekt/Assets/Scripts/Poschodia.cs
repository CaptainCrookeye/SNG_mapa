using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Poschodia : MonoBehaviour
{
    [SerializeField] Kamera kamera;
    [SerializeField] Transform poschodie1;
    [SerializeField] Transform poschodie2;
    int AktualnePoschodie = 2;
    [SerializeField] Image Button1; //provizorne
    [SerializeField] Image Button2; //provizorne
    public void Poschodie1()
    {
        if(AktualnePoschodie!=1)
        {
            Camera.main.transform.position = poschodie1.position;
            kamera.MinY -= 100;
            kamera.MaxY -= 100;
            kamera.ResetPos = poschodie1;
            AktualnePoschodie = 1;
            Button1.color = new Color(0, 0.6470588f, 1, 1);
            Button2.color = Color.white;
        }
    }
    public void Poschodie2()
    {
        if (AktualnePoschodie!=2)
        {
            Camera.main.transform.position = poschodie2.position;
            kamera.MinY += 100;
            kamera.MaxY += 100;
            kamera.ResetPos = poschodie2;
            AktualnePoschodie = 2;
            Button2.color = new Color(0,0.6470588f,1,1);
            Button1.color = Color.white;
        }       
    }
}
