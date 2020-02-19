using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class updatePlayerHUD : MonoBehaviour
{
    
    private TextMeshPro playerHUD;

    private GameObject camera;
    
    private Boolean key1Stat;
    private Boolean key2Stat;

    void Start()
    {
        camera = GameObject.Find("PLAYER/Main Camera");
        playerHUD = GetComponent<TextMeshPro>();
    }
    
    void Update()
    {
        clickToDelete test = camera.GetComponent<clickToDelete>();
        
        key1Stat = test.key1;
        key2Stat = test.key2;
        
        updateHUD();
    }
    
    private void updateHUD()
    {
        if (key1Stat == false && key2Stat == false) playerHUD.text = "Gold Key: Lost \nSilver Key: Lost";
        if (key1Stat == true && key2Stat == false) playerHUD.text = "Gold Key: Found \nSilver Key: Lost";
        if (key1Stat == false && key2Stat == true) playerHUD.text = "Gold Key: Lost \nSilver Key: Found";
        if (key1Stat == true && key2Stat == true) playerHUD.text = "Gold Key: Found \nSilver Key: Found";
    }
}
