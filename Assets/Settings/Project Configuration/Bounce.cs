using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Bounce : MonoBehaviour
{
    public static GameObject cube;
    [Tooltip ("Changes the rotation speed of the cube")]
    public float bouncespeed = 1f;
    
    //Called every frame the app is running
    // Note that "*" represents multiplication
    private double bounce;
    private float incre;


    private Vector3 loc;
    private void Start()
    {
        cube = GameObject.Find("Cube");
        loc = cube.transform.position;
        Debug.Log(loc);
    }

    void Update()
    {
        bounce = Math.Sin(incre);
        incre += 0.005f;
        cube.transform.position = new Vector3(loc.x, loc.y + (float)(bounce*bouncespeed), loc.z);
    }
}
