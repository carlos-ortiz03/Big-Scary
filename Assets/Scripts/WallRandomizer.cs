using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = System.Random;

public class WallRandomizer : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {

        
        
        Random rnd = new Random();
        int location = rnd.Next(5, 495);

        GameObject newWall = Instantiate(wallAddIn);
        newWall.transform.position = new Vector3(location, 10, location);

    }


    public GameObject wallAddIn;
    // Update is called once per frame
    void Update()
    {
        

    }
}
