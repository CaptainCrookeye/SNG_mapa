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
    GameObject popis;
    public static bool instance = false;
    public void OpenClose()
    {
        if(!instance)
        {
            instance = true;
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
            kamera.KameraReset();
            popis = GameObject.Find(input.text);
            GameObject MojPopis = popis.transform.parent.gameObject;
            MojPopis.transform.GetChild(0).gameObject.SetActive(true); //Pozadie
            MojPopis.transform.GetChild(1).gameObject.SetActive(true); //Button back
            MojPopis.transform.GetChild(2).gameObject.SetActive(true); //Image
            MojPopis.transform.GetChild(3).gameObject.SetActive(true); //Trieda
            MojPopis.GetComponent<Animator>().SetBool("Open", true);
            Triedy.control = true;
            instance = false;
            SearchBar.SetActive(false);
        }       
    }
}
