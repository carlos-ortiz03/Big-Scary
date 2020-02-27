using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class openDoorPolicy : MonoBehaviour
{
    private GameObject Door;

    private Camera cam;

    private Boolean isDoorOpen = false;
    private Boolean key1Stat;
    private Boolean key2Stat;
    private Boolean ready = false;
    
    void Start()
    {
        Door = GameObject.FindWithTag("Door");
        cam = GetComponent<Camera>();
    }

    void Update()
    {
        testDoor();

        clickToDelete test = cam.GetComponent<clickToDelete>();

        key1Stat = test.key1;
        key2Stat = test.key2;
    }

    private void swapBoolean()
    {
        isDoorOpen = !isDoorOpen;
    }

    private void testDoor()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.gameObject.Equals(Door))
                {
                    if (key1Stat == true && key2Stat == true)
                    {
                        swapBoolean();
                        if (isDoorOpen == true)
                        {
                            Door.transform.rotation = Quaternion.Euler(0, -90, 0);
                        }
                        if (isDoorOpen == false)
                        {
                            Door.transform.rotation = Quaternion.Euler(0, 180, 0);
                        }
                    }
                }
            }
        }
    }
}
