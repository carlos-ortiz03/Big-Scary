using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class updatePlayerHUD : MonoBehaviour
{

    private GameObject camera;

    private GameObject i1;
    private GameObject i2;
    private GameObject i3;
    private GameObject i4;
    
    private Boolean key1Stat;
    private Boolean key2Stat;

    private Boolean isOpen;

    void Start()
    {
        camera = GameObject.FindWithTag("MainCamera");
        i1 = GameObject.FindWithTag("I1");
        i2 = GameObject.FindWithTag("I2");
        i3 = GameObject.FindWithTag("I3");
        i4 = GameObject.FindWithTag("I4");
        isOpen = false;
    }

    void Update()
    {
        clickToDelete test = camera.GetComponent<clickToDelete>();
        
        key1Stat = test.key1;
        key2Stat = test.key2;

        if (Input.GetKeyDown(KeyCode.Tab)) isOpen = !isOpen;
        if (Input.GetKeyDown(KeyCode.K))
        {
            Debug.Log("isOpen: " + isOpen);
        }

        updateHUD();
    }

    private void updateHUD()
    {
        if (isOpen == true)
        {
            if (key1Stat == false && key2Stat == false)
            {
                i1.SetActive(true);
                i2.SetActive(false);
                i3.SetActive(false);
                i4.SetActive(false);
                Debug.Log("i1");
            }
            if (key1Stat == false && key2Stat == true)
            {
                i1.SetActive(false);
                i2.SetActive(true);
                i3.SetActive(false);
                i4.SetActive(false);
                Debug.Log("i2");
            }
            if (key1Stat == true && key2Stat == false)
            {
                i1.SetActive(false);
                i2.SetActive(false);
                i3.SetActive(true);
                i4.SetActive(false);
                Debug.Log("i3");
            }
            if (key1Stat == true && key2Stat == true)
            {
                i1.SetActive(false);
                i2.SetActive(false);
                i3.SetActive(false);
                i4.SetActive(true);
                Debug.Log("i4");
            }
        }
        if (isOpen == false)
        {
            i1.SetActive(false);
            i2.SetActive(false);
            i3.SetActive(false);
            i4.SetActive(false);
        }
    }
}
