using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lightsOff : MonoBehaviour
{
    private GameObject b1;
    private GameObject b2;
    private GameObject b3;
    private GameObject b4;
    private GameObject b5;

    public Material black;
    public Material invis;

    private Boolean lights;
    
    void Start()
    {
        b1 = GameObject.Find("Environment/Structure/Frame/East Barrier");
        b2 = GameObject.Find("Environment/Structure/Frame/West Barrier");
        b3 = GameObject.Find("Environment/Structure/Frame/North Barrier");
        b4 = GameObject.Find("Environment/Structure/Frame/South Barrier");
        b5 = GameObject.Find("Environment/Structure/Frame/Roof");
    }
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Backspace))
        {
            lights = !lights;
            changeLights();
        }
    }

    private void changeLights()
    {
        if (lights == true)
        {
            b1.GetComponent<MeshRenderer>().material = invis;
            b2.GetComponent<MeshRenderer>().material = invis;
            b3.GetComponent<MeshRenderer>().material = invis;
            b4.GetComponent<MeshRenderer>().material = invis;
            b5.GetComponent<MeshRenderer>().material = invis;
        }
        if (lights == false)
        {
            b1.GetComponent<MeshRenderer>().material = black;
            b2.GetComponent<MeshRenderer>().material = black;
            b3.GetComponent<MeshRenderer>().material = black;
            b4.GetComponent<MeshRenderer>().material = black;
            b5.GetComponent<MeshRenderer>().material = black;
        }
    }
}
