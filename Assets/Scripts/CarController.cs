﻿using UnityEngine;
using System.Collections;

public class CarController : MonoBehaviour
{
    // Use this for initialization
    void Start ()
    {

    }

    // Update is called once per frame
    void Update ()
    {
        if (Input.GetKey ("up")) {
            Debug.Log ("up");
        }
    }
}
