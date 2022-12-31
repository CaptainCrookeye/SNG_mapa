using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Triedy : MonoBehaviour
{
    [SerializeField] GameObject popis;
    public static bool control = false;
    [SerializeField] Animator anim;
    public void Open()
    {
        if(!control && !Vyhladavanie.instance)
        {
            popis.transform.GetChild(0).gameObject.SetActive(true); //Pozadie
            popis.transform.GetChild(1).gameObject.SetActive(true); //Button back
            popis.transform.GetChild(2).gameObject.SetActive(true); //Image
            popis.transform.GetChild(3).gameObject.SetActive(true); //Trieda
            anim.SetBool("Open", true);
            control = true;
        }     
    }
    public void Close()
    {
        StartCoroutine(close());
        control = false;       
    }
    IEnumerator close()
    {
        anim.SetBool("Open", false);
        yield return new WaitForSeconds(0.6f);
        popis.transform.GetChild(0).gameObject.SetActive(false);
        popis.transform.GetChild(1).gameObject.SetActive(false);
        popis.transform.GetChild(2).gameObject.SetActive(false);
        popis.transform.GetChild(3).gameObject.SetActive(false);
    }
}