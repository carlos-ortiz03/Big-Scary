using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class updatePlayerHUD : MonoBehaviour
{

    private GameObject camera;

    private GameObject key1Obj;
    private GameObject key2Obj;
    private GameObject inventory;
    
    private Boolean key1Stat;
    private Boolean key2Stat;

    private Boolean isOpen;

    void Start()
    {
        camera = GameObject.FindWithTag("MainCamera");
        key1Obj = GameObject.FindWithTag("Key1Obj");
        key2Obj = GameObject.FindWithTag("Key2Obj");
        inventory = GameObject.FindWithTag("Inventory");
        isOpen = false;
    }

    void Update()
    {
        clickToDelete test = camera.GetComponent<clickToDelete>();
        
        key1Stat = test.key1;
        key2Stat = test.key2;

        if (Input.GetKeyDown(KeyCode.Tab)) isOpen = !isOpen;

        updateHUD();
    }

    private void updateHUD()
    {
        inventory.SetActive(isOpen);
        key1Obj.SetActive(key1Stat);
        key2Obj.SetActive(key2Stat);
    }
}
