using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    [SerializeField] GameObject mapa0;
    [SerializeField] GameObject buttons0;
    [SerializeField] GameObject mapa_1;
    [SerializeField] GameObject buttons_1;
    [SerializeField] GameObject mapa2;
    [SerializeField] GameObject buttons2;
    [SerializeField] GameObject mapa1;
    [SerializeField] GameObject buttons1;
    [SerializeField] GameObject mapa3;
    [SerializeField] GameObject buttons3;
    [SerializeField] GameObject mapa4;
    [SerializeField] GameObject buttons4;
    int k = 0;
    int i = 0;
    bool instance = false;
    public void Right()
    {
        if(!instance)
            StartCoroutine(right());
    }
    public void Left()
    {
        if (!instance)
            StartCoroutine(left());
    }
    public void Default()
    {
        if(!instance)
        {
            mapa0.transform.rotation = Quaternion.Euler(0, 0, 0);
            buttons0.transform.rotation = Quaternion.Euler(0, 0, 0);
            mapa_1.transform.rotation = Quaternion.Euler(0, 0, 0);
            buttons_1.transform.rotation = Quaternion.Euler(0, 0, 0);
            mapa1.transform.rotation = Quaternion.Euler(0, 0, 0);
            buttons1.transform.rotation = Quaternion.Euler(0, 0, 0);
            mapa2.transform.rotation = Quaternion.Euler(0, 0, 0);
            buttons2.transform.rotation = Quaternion.Euler(0, 0, 0);
            mapa3.transform.rotation = Quaternion.Euler(0, 0, 0);
            buttons3.transform.rotation = Quaternion.Euler(0, 0, 0);
            mapa4.transform.rotation = Quaternion.Euler(0, 0, 0);
            buttons4.transform.rotation = Quaternion.Euler(0, 0, 0);
            i = 0;
            k = 0;
        }    
    }
    IEnumerator right()
    {
        instance = true;
        for (i = k; i >= k-90; i--)
        {
            mapa0.transform.rotation = Quaternion.Euler(0, 0, i);
            buttons0.transform.rotation = Quaternion.Euler(0, 0, i);
            mapa_1.transform.rotation = Quaternion.Euler(0, 0, i);
            buttons_1.transform.rotation = Quaternion.Euler(0, 0, i);
            mapa1.transform.rotation = Quaternion.Euler(0, 0, i);
            buttons1.transform.rotation = Quaternion.Euler(0, 0, i);
            mapa2.transform.rotation = Quaternion.Euler(0, 0, i);
            buttons2.transform.rotation = Quaternion.Euler(0, 0, i);
            mapa3.transform.rotation = Quaternion.Euler(0, 0, i);
            buttons3.transform.rotation = Quaternion.Euler(0, 0, i);
            mapa4.transform.rotation = Quaternion.Euler(0, 0, i);
            buttons4.transform.rotation = Quaternion.Euler(0, 0, i);
            yield return new WaitForSeconds(0.01f);
        }
        k = i + 1;
        instance = false;
    }
    IEnumerator left()
    {
        instance = true;
        for (i = k; i <= k + 90; i++)
        {
            mapa0.transform.rotation = Quaternion.Euler(0, 0, i);
            buttons0.transform.rotation = Quaternion.Euler(0, 0, i);
            mapa_1.transform.rotation = Quaternion.Euler(0, 0, i);
            buttons_1.transform.rotation = Quaternion.Euler(0, 0, i);
            mapa1.transform.rotation = Quaternion.Euler(0, 0, i);
            buttons1.transform.rotation = Quaternion.Euler(0, 0, i);
            mapa2.transform.rotation = Quaternion.Euler(0, 0, i);
            buttons2.transform.rotation = Quaternion.Euler(0, 0, i);
            mapa3.transform.rotation = Quaternion.Euler(0, 0, i);
            buttons3.transform.rotation = Quaternion.Euler(0, 0, i);
            mapa4.transform.rotation = Quaternion.Euler(0, 0, i);
            buttons4.transform.rotation = Quaternion.Euler(0, 0, i);
            yield return new WaitForSeconds(0.01f);
        }
        k = i - 1;
        instance = false;
    }
}
