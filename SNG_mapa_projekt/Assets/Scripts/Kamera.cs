using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kamera : MonoBehaviour
{
    //toto dat na Main Camera len pre Android
    Vector3 StartTouch;
    [SerializeField] float MinZoom = 10;
    [SerializeField] float DefaultZoom = 17;
    [SerializeField] float MaxZoom = 20;
    public Transform ResetPos;
    public static bool CanMove = true;
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            StartTouch = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        }    
        if(Input.touchCount == 2) //Zoom Android
        {
            Touch touch0 = Input.GetTouch(0);
            Touch touch1 = Input.GetTouch(1);
            Vector2 touch0Prev = touch0.position - touch0.deltaPosition;
            Vector2 touch1Prev = touch1.position - touch1.deltaPosition;
            float difference = (touch0.position - touch1.position).magnitude - (touch0Prev - touch1Prev).magnitude;
            Zoom(difference * 0.01f);
        }
        else if (Input.GetMouseButton(0))
        {
            Vector3 direction = StartTouch - Camera.main.ScreenToWorldPoint(Input.mousePosition);
            if(CanMove)
                Camera.main.transform.Translate(direction);
        }
        Zoom(Input.GetAxisRaw("Mouse ScrollWheel")*2.5f); //Zoom PC         
    }
    void Zoom(float increment)
    {
        Camera.main.orthographicSize = Mathf.Clamp(Camera.main.orthographicSize - increment, MinZoom, MaxZoom);
    }
    public void KameraReset()
    {
        Camera.main.orthographicSize = DefaultZoom;
        Camera.main.transform.position = ResetPos.position;
        CanMove = true;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        CanMove = false;
        Camera.main.transform.position = ResetPos.position;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        CanMove = true;
    }
}
