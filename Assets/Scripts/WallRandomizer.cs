using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.XR;
using UnityEngine;
using Random = System.Random;

public class WallRandomizer : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {


        Random rnd = new Random();
        int lastXCoordinate = rnd.Next(100, 400);
        while (lastXCoordinate == 250)
        {
            lastXCoordinate = rnd.Next(100, 400);
        }

        GameObject newWall = Instantiate(wallAddIn);
        newWall.transform.position = new Vector3(lastXCoordinate, 10, 62.5f);
        newWall.transform.localScale = new Vector3(1, 100, 125);
        int zLength = 125;

        int times = 0;
        bool horizontal = true;
        while (times < 6)
        {
            if (newWall.transform.position.x > 250 && horizontal)
            {
                int value = rnd.Next(100, 250);
                newWall = Instantiate(wallAddIn);
                lastXCoordinate = lastXCoordinate - value / 2;
                newWall.transform.position = new Vector3(lastXCoordinate, 10, zLength);
                lastXCoordinate = lastXCoordinate - value / 2;
                newWall.transform.localScale = new Vector3(value, 100, 1);
                horizontal = false;
            }
            
            else if (newWall.transform.position.x < 250 && horizontal)
            {
                int value = rnd.Next(100, 250);
                newWall = Instantiate(wallAddIn);
                lastXCoordinate = lastXCoordinate + value / 2;
                newWall.transform.position = new Vector3(lastXCoordinate, 10, zLength);
                lastXCoordinate = lastXCoordinate + value / 2;
                newWall.transform.localScale = new Vector3(value, 100, 1);
                horizontal = false;
            }
            
            else if (!horizontal)
            { 
                Debug.Log("hello");

                if (times == 5)
                {
                    int value = 500 - zLength;
                    newWall = Instantiate(wallAddIn);
                    newWall.transform.position = new Vector3(lastXCoordinate, 10, zLength + value / 2);
                    newWall.transform.localScale = new Vector3(1, 100, value);
                }
                else
                {
                    int value = rnd.Next(75, 150);
                    newWall = Instantiate(wallAddIn);
                    zLength += value;
                    newWall.transform.position = new Vector3(lastXCoordinate, 10, zLength - value / 2);
                    newWall.transform.localScale = new Vector3(1, 100, value);
                    horizontal = true; 
                }
                
            }

            times += 1;

        }

    }


    public GameObject wallAddIn;
    // Update is called once per frame
    void Update()
    {
        

    }
}
