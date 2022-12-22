using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Klik : MonoBehaviour
{
    [SerializeField] GameObject popis;
    public static bool control = false;
    public void Open()
    {
        if(!control)
        {
            popis.SetActive(true);
            control = true;
        }     
    }
    public void Close()
    {
        popis.SetActive(false);
        control = false;
    }
}