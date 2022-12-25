using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Poschodia : MonoBehaviour
{
    [SerializeField] GameObject button1;
    [SerializeField] GameObject button2;
    [SerializeField] GameObject text;
    private void Update()
    {
        if(!Klik.control)
        {
            text.SetActive(true);
            button1.SetActive(true);
            button2.SetActive(true);
        }
        else
        {
            text.SetActive(false);
            button1.SetActive(false);
            button2.SetActive(false);
        }
    }
    public void Poschodie1()
    {
        SceneManager.LoadScene("1.poschodie");
    }
    public void Poschodie2()
    {
        SceneManager.LoadScene("2.poschodie");
    }
}
