using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Draw_test : MonoBehaviour
{
    LineRenderer lr;
    [SerializeField] Transform target;
    void Start()
    {
        lr = GetComponent<LineRenderer>();
    }
    void Update()
    {
        lr.SetPosition(0, transform.position);
        lr.SetPosition(1, target.position);
    }
}
