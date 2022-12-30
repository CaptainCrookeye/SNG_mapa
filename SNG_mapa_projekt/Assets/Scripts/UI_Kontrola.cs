using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_Kontrola : MonoBehaviour
{
    [SerializeField] GameObject Despawnable;
    void Update()
    {
        if(!Triedy.control)
        {
            Despawnable.SetActive(true);
        }
        else
        {
            Despawnable.SetActive(false);
        }
    }
}
