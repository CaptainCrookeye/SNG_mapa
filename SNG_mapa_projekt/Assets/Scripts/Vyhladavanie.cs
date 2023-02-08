using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.Events;
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
    [SerializeField] GameObject vyhladavania;
    [SerializeField] GameObject _1;
    [SerializeField] GameObject _2;
    [SerializeField] GameObject _3;
    [SerializeField] GameObject _4;
    Button button_1;
    Button button_2;
    Button button_3;
    Button button_4;
    TMP_Text text_1;
    TMP_Text text_2;
    TMP_Text text_3;
    TMP_Text text_4;
    [SerializeField] Animator vyhlanim;
    GameObject trieda;
    List<string> triedy = new List<string>();
    List<GameObject> zalohy = new List<GameObject>();
    GameObject MojPopis;
    GameObject popis;
    public static bool instance = false;
    public static bool vyhlinstance = false;
    int kontrola = 0;
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
    public void Search()
    {
        if (!Triedy.control)
        {
            //setup
            for (int i = 0; i < triedy.Count; i++)
            {
                zalohy[i].SetActive(true);
            }
            zalohy.Clear();
            triedy.Clear();
            MojPopis = null;
            trieda = GameObject.Find(input.text.ToLower());
            if (trieda != null && trieda.transform.parent.gameObject.name != "Zoznam učiteľov")
                trieda = null;
            kontrola = 0;
            while (trieda != null && kontrola < 99) //hladanie vsetkych objektov podla mena
            {
                if (trieda == null)
                    break;
                MojPopis = trieda.transform.parent.gameObject;
                zalohy.Add(trieda);
                triedy.Add(MojPopis.transform.parent.gameObject.name);
                trieda.SetActive(false);
                trieda = GameObject.Find(input.text.ToLower());
                kontrola++;
            }
            //vyhladavanie
            if (triedy.Count==0)
                ErrorText.SetActive(true);           
            else if (triedy.Count==1) //1 trieda
            {
                SearchButton.sprite = Image_default;
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
                ErrorText.SetActive(false);
                VyhlOpenClose();
                _3.SetActive(true);
                _4.SetActive(true);
                if (triedy.Count == 2)
                {
                    _3.SetActive(false);
                    _4.SetActive(false);
                    text_1 = _1.transform.GetChild(0).GetComponent<TMP_Text>();
                    button_1 = _1.transform.GetChild(1).GetComponent<Button>();
                    text_1.text = triedy[0];
                    button_1.onClick.AddListener(delegate { Search_multi(0); });
                    text_2 = _2.transform.GetChild(0).GetComponent<TMP_Text>();
                    button_2 = _2.transform.GetChild(1).GetComponent<Button>();
                    text_2.text = triedy[1];
                    button_2.onClick.AddListener(delegate { Search_multi(1); });
                }
                else if (triedy.Count == 3)
                {
                    _4.SetActive(false);
                    text_1 = _1.transform.GetChild(0).GetComponent<TMP_Text>();
                    button_1 = _1.transform.GetChild(1).GetComponent<Button>();
                    text_1.text = triedy[0];
                    button_1.onClick.AddListener(delegate { Search_multi(0); });
                    text_2 = _2.transform.GetChild(0).GetComponent<TMP_Text>();
                    button_2 = _2.transform.GetChild(1).GetComponent<Button>();
                    text_2.text = triedy[1];
                    button_2.onClick.AddListener(delegate { Search_multi(1); });
                    text_3 = _3.transform.GetChild(0).GetComponent<TMP_Text>();
                    button_3 = _3.transform.GetChild(1).GetComponent<Button>();
                    text_3.text = triedy[2];
                    button_3.onClick.AddListener(delegate { Search_multi(2); });
                }
                else if (triedy.Count == 4)
                {
                    text_1 = _1.transform.GetChild(0).GetComponent<TMP_Text>();
                    button_1 = _1.transform.GetChild(1).GetComponent<Button>();
                    text_1.text = triedy[0];
                    button_1.onClick.AddListener(delegate { Search_multi(0); });
                    text_2 = _2.transform.GetChild(0).GetComponent<TMP_Text>();
                    button_2 = _2.transform.GetChild(1).GetComponent<Button>();
                    text_2.text = triedy[1];
                    button_2.onClick.AddListener(delegate { Search_multi(1); });
                    text_3 = _3.transform.GetChild(0).GetComponent<TMP_Text>();
                    button_3 = _3.transform.GetChild(1).GetComponent<Button>();
                    text_3.text = triedy[2];
                    button_3.onClick.AddListener(delegate { Search_multi(2); });
                    text_4 = _4.transform.GetChild(0).GetComponent<TMP_Text>();
                    button_4 = _4.transform.GetChild(1).GetComponent<Button>();
                    text_4.text = triedy[3];
                    button_4.onClick.AddListener(delegate { Search_multi(3); });
                }
                else
                    Debug.LogError("Moc tried na 1 meno.");
            }
        }        
    }
    void Search_multi(int o)
    {
        SearchButton.sprite = Image_default;
        popis = GameObject.Find(triedy[o]);
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
        kamera.KameraReset();
    }
    public void VyhlOpenClose()
    {
        if (!vyhlinstance)
        {
            vyhlinstance = true;
            vyhlanim.SetBool("Open", true);
            vyhladavania.transform.GetChild(0).gameObject.SetActive(true);
        }
        else
        {
            StartCoroutine(vyhlclose());
        }
    }
    IEnumerator vyhlclose()
    {
        vyhlanim.SetBool("Open", false);
        vyhlinstance = false;
        yield return new WaitForSeconds(0.6f);
        vyhladavania.transform.GetChild(0).gameObject.SetActive(false);
    }
}
