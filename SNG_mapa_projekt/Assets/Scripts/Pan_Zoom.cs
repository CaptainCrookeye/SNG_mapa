using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pan_Zoom : MonoBehaviour
{
    //toto dat na Main Camera len pre Android
    Vector3 StartTouch;
    [SerializeField] float MinZoom = 1;
    [SerializeField] float MaxZoom = 8;
    void Update()
    {
        if(Input.GetMouseButtonDown(0) && !Klik.control)
        {
            StartTouch = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        }
        
        if(Input.touchCount == 2)
        {
            Touch touch0 = Input.GetTouch(0);
            Touch touch1 = Input.GetTouch(1);
            Vector2 touch0Prev = touch0.position - touch0.deltaPosition;
            Vector2 touch1Prev = touch1.position - touch1.deltaPosition;
            float difference = (touch0.position - touch1.position).magnitude - (touch0Prev - touch1Prev).magnitude;
            Zoom(difference * 0.01f);
        }
        else if (Input.GetMouseButton(0) && !Klik.control)
        {
            Vector3 direction = StartTouch - Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Camera.main.transform.Translate(direction);
        }
        Zoom(Input.GetAxis("Mouse ScrollWheel"));
    }
    void Zoom(float increment)
    {
        Camera.main.orthographicSize = Mathf.Clamp(Camera.main.orthographicSize - increment, MinZoom, MaxZoom);
    }
}
