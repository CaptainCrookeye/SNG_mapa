using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kamera : MonoBehaviour
{
    //toto dat na Main Camera len pre Android
    Vector3 StartTouch;
    Rigidbody2D rb;
    [Header("Zoom")]
    [SerializeField] float MinZoom = 10;
    [SerializeField] float DefaultZoom = 17;
    [SerializeField] float MaxZoom = 20;
    [Header("Camera movement")]
    [SerializeField] float MinX = -30;
    [SerializeField] float MaxX = 30;
    [SerializeField] float MinY = -25;
    [SerializeField] float MaxY = 25;
    float x;
    float y;
    bool CanMove = true;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        x = Camera.main.transform.position.x;
        y = Camera.main.transform.position.y;
        if(x<=MaxX && x>=MinX && y<=MaxY && y>=MinY)
        {
            CanMove = true;
            rb.velocity = Vector2.zero;
        }
        else
        {
            CanMove = false;
            if(x>MaxX)
            {
                rb.velocity = Vector2.left*20;
            }
            if(x<MinX)
            {
                rb.velocity = Vector2.right*20;
            }
            if(y>MaxY)
            {
                rb.velocity = Vector2.down*20;
            }
            if(y<MinY)
            {
                rb.velocity = Vector2.up*20;
            }
        }
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
            {
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
        rb.position = new Vector3(0,0);
    }
}
