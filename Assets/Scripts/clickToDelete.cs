using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class clickToDelete : MonoBehaviour
{
    private GameObject Key1;
    private GameObject Key2;

    private Camera cam;
    
    public Boolean key1 = false;
    public Boolean key2 = false;

    void Start()
    {
        Key1 = GameObject.Find("Test Environment/Key 1");
        Key2 = GameObject.Find("Test Environment/Key 2");
        cam = GetComponent<Camera>();
    }
    
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                //Works until this point
                if (hit.collider.gameObject.Equals(Key1))
                {
                    Destroy(Key1);
                    key1 = true;
                }
                if (hit.collider.gameObject.Equals(Key2))
                {
                    Destroy(Key2);
                    key2 = true;
                }
            }
        }
    }
}
