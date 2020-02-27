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
        int lastXCoordinate = rnd.Next(15, 60);
        while (lastXCoordinate == 37.5)
        {
            lastXCoordinate = rnd.Next(15, 60);
        }

        GameObject newWall = Instantiate(wallAddIn);
        newWall.transform.position = new Vector3(lastXCoordinate, 2f, 9.85f);
        newWall.transform.localScale = new Vector3(1, 10, 18.75f);
        float zLength = 18.75f;

        int times = 0;
        bool horizontal = true;
        while (times < 6)
        {
            if (newWall.transform.position.x > 37.5 && horizontal)
            {
                int value = rnd.Next(15, 37);
                newWall = Instantiate(wallAddIn);
                lastXCoordinate = lastXCoordinate - value / 2;
                newWall.transform.position = new Vector3(lastXCoordinate, 2, zLength);
                lastXCoordinate = lastXCoordinate - value / 2;
                newWall.transform.localScale = new Vector3(value, 10, 1);
                horizontal = false;
            }
            
            else if (newWall.transform.position.x < 37.5 && horizontal)
            {
                int value = rnd.Next(15, 37);
                newWall = Instantiate(wallAddIn);
                lastXCoordinate = lastXCoordinate + value / 2;
                newWall.transform.position = new Vector3(lastXCoordinate, 2, zLength);
                lastXCoordinate = lastXCoordinate + value / 2;
                newWall.transform.localScale = new Vector3(value, 10, 1);
                horizontal = false;
            }
            
            else if (!horizontal)
            { 
                Debug.Log("hello");

                if (times == 5)
                {
                    float value = 75 - zLength;
                    newWall = Instantiate(wallAddIn);
                    newWall.transform.position = new Vector3(lastXCoordinate, 2, zLength + value / 2);
                    newWall.transform.localScale = new Vector3(1, 10, value);
                }
                else
                {
                    int value = rnd.Next(11, 27);
                    newWall = Instantiate(wallAddIn);
                    zLength += value;
                    newWall.transform.position = new Vector3(lastXCoordinate, 2, zLength - value / 2);
                    newWall.transform.localScale = new Vector3(1, 10, value);
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
