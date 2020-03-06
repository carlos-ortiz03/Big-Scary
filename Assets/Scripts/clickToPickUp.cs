using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickToPickUp : MonoBehaviour
{
    private GameObject lantern;
    private GameObject arm;

    private Camera cam;

    private Vector3 armPos;

    public Boolean isPickedUp = false;

    void Start()
    {
        lantern = GameObject.FindWithTag("Lantern");
        arm = GameObject.FindWithTag("Arm");
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
                if (hit.collider.gameObject.Equals(lantern))
                {
                    isPickedUp = true;
                }
            }
        }
        if (Input.GetMouseButtonDown(1))
        {
            isPickedUp = false;
            lantern.transform.position = new Vector3(armPos.x,armPos.y - 0.8f, armPos.z);
        }
        objectFollow();
    }

    private void objectFollow()
    {
        armPos = arm.transform.position;
        float xRot = cam.transform.rotation.x;
        float zRot = cam.transform.rotation.z;
        lantern.transform.rotation = Quaternion.Euler(xRot, 0, zRot);
        if (isPickedUp == true)
        {
            lantern.transform.position = new Vector3(armPos.x, armPos.y, armPos.z);
            
        }
    }
}    
