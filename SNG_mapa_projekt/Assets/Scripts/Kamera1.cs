using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kamera1 : MonoBehaviour
{
    //toto dat na Main Camera len pre Android
    Vector3 StartTouch;
    Rigidbody2D rb;
    [Header("Zoom")]
    [SerializeField] float MinZoom = 10;
    [SerializeField] float DefaultZoom = 17;
    [SerializeField] float MaxZoom = 20;
    [Header("Camera movement")]
    public float MinX = -42; //2.poschodie
    public float MaxX = 22; //2.poschodie
    public float MinY = -26; //2.poschodie
    public float MaxY = 26; //2.poschodie
    float x;
    float y;
    bool CanMove = true;
    public Transform ResetPos;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        
        if (Input.GetMouseButtonDown(0))
        {
            StartTouch = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        }    
        if(Input.GetMouseButtonUp(0))
        {
            Camera.main.transform.position = gameObject.transform.position;
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
            {
                gameObject.transform.Translate(direction);
                Camera.main.transform.Translate(direction);
            }
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
        gameObject.transform.position = ResetPos.position;
    }
}
