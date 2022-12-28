using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Klik : MonoBehaviour
{
    [SerializeField] GameObject popis;
    public static bool control = false;
    [SerializeField] Animator anim;
    public void Open()
    {
        if(!control)
        {
            popis.SetActive(true);
            control = true;
            anim.SetBool("Open", true);
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
        popis.SetActive(false);
    }
}