using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class clickToDelete : MonoBehaviour
{
    private GameObject Key1;
    private GameObject Key2;
    
    void Start()
    {
        Key1 = GameObject.Find("Environment/Key 1");
        Key2 = GameObject.Find("Environment/Key 2");
    }
    
    void Update()
    {
        OnMouseDown();
    }

    private void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(1))
        {
            if (gameObject.Equals(Key1))
            {
                Destroy(Key1);
            }
            if (gameObject.Equals(Key2))
            {
                Destroy(Key2);
            }
        }
    }
    
    //Unsure if this works quite yet. We'll find out when the player movement is further implemented.
}
