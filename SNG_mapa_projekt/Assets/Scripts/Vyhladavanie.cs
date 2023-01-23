using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class Vyhladavanie : MonoBehaviour
{
    [SerializeField] TMP_InputField input;
    [SerializeField] GameObject SearchBar;
    [SerializeField] Animator anim;
    [SerializeField] Kamera kamera;
    [SerializeField] GameObject ErrorText;
    [SerializeField] Image SearchButton;
    [SerializeField] Sprite Image_default;
    [SerializeField] Sprite Image_pressed;
    GameObject trieda;
    List<string> triedy = new List<string>();
    GameObject MojPopis;
    GameObject popis;
    public static bool instance = false;
    int k = 0;
    public void OpenClose()
    {
        if(!instance)
        {
            instance = true;
            ErrorText.SetActive(false);
            SearchBar.SetActive(true);
            anim.SetBool("Open",true);
            SearchButton.sprite = Image_pressed;
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
        SearchButton.sprite = Image_default;
        yield return new WaitForSeconds(0.6f);      
        SearchBar.SetActive(false);
    }
    public void Search1()
    {
        if(!Triedy.control)
        {         
            trieda = GameObject.Find(input.text);
            if(trieda != null)
            {
                SearchButton.sprite = Image_default;
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
    public void Search()//testing
    {
       // triedy = GameObject.FindGameObjectsWithTag("Search_multi");
        trieda = GameObject.Find(input.text);
        k = 0;
        while (trieda != null && k<99)
        {
            if (trieda == null)
                break;
            MojPopis = trieda.transform.parent.gameObject;
            triedy.Add(MojPopis.transform.parent.gameObject.name);
            trieda.SetActive(false);
            k++;
        }
        for(int i=0;i<triedy.Count;i++)
           Debug.Log(triedy[i]);
        Debug.Log(k);
    }
}
