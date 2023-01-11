using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Vyhladavanie : MonoBehaviour
{
    [SerializeField] TMP_InputField input;
    [SerializeField] GameObject SearchBar;
    [SerializeField] Animator anim;
    [SerializeField] Kamera kamera;
    [SerializeField] GameObject ErrorText;
    GameObject trieda;
    GameObject MojPopis;
    GameObject popis;
    public static bool instance = false;
    public void OpenClose()
    {
        if(!instance)
        {
            instance = true;
            ErrorText.SetActive(false);
            SearchBar.SetActive(true);
            anim.SetBool("Open",true);
        }
        else
        {
            StartCoroutine(close());
        }
    }
    IEnumerator close()
    {
        anim.SetBool("Open", false);
        instance = false;
        yield return new WaitForSeconds(0.6f);      
        SearchBar.SetActive(false);
    }
    public void Search()
    {
        if(!Triedy.control)
        {         
            trieda = GameObject.Find(input.text);
            if(trieda != null)
            {
                MojPopis = trieda.transform.parent.gameObject;
                popis = MojPopis.transform.parent.gameObject;
                popis.transform.GetChild(0).gameObject.SetActive(true); //Pozadie
                popis.transform.GetChild(1).gameObject.SetActive(true); //Button back
                popis.transform.GetChild(2).gameObject.SetActive(true); //Image
                popis.transform.GetChild(3).gameObject.SetActive(true); //Trieda
                popis.transform.GetChild(4).gameObject.SetActive(true);
                popis.transform.GetChild(5).gameObject.SetActive(true);
                popis.GetComponent<Animator>().SetBool("Open", true);
                Triedy.control = true;
                instance = false;
                SearchBar.SetActive(false);
                ErrorText.SetActive(false);
                kamera.KameraReset();              
            }
            else 
            {
                ErrorText.SetActive(true);
            }
        }       
    }
}
