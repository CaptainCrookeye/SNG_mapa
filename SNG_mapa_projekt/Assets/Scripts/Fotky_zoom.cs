using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fotky_zoom : MonoBehaviour
{
    GameObject popis;
    Animator anim;
    bool fullscreen = false;
    bool running = false;
    private void Start()
    {
        popis = gameObject.transform.parent.gameObject;
        anim = GetComponent<Animator>();
    }
    void Update()
    {
        if(fullscreen &&!running && Input.GetMouseButtonDown(0))
        {
            StartCoroutine(Close());
        }
    }
    public void Click()
    {
        if(!fullscreen && !running)
        {
            StartCoroutine(Fullscreen());
        }
    }
    IEnumerator Fullscreen()
    {
        running = true;      
        anim.SetBool("Fullscreen", true);
        popis.transform.GetChild(3).gameObject.SetActive(false); //Trieda 
        popis.transform.GetChild(4).gameObject.SetActive(false); //Uèitelia 
        popis.transform.GetChild(5).gameObject.SetActive(false); //[Uèitelia]
        fullscreen = true;
        yield return new WaitForSeconds(0.6f);
        running = false;
    }
    IEnumerator Close()
    {
        running = true;
        anim.SetBool("Fullscreen", false);     
        fullscreen = false;
        yield return new WaitForSeconds(0.6f);
        popis.transform.GetChild(3).gameObject.SetActive(true); //Trieda 
        popis.transform.GetChild(4).gameObject.SetActive(true); //Uèitelia 
        popis.transform.GetChild(5).gameObject.SetActive(true); //[Uèitelia]
        running = false;
    }
}
