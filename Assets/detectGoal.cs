using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

using System.Drawing;
public class detectGoal : MonoBehaviour
{
    // Start is called before the first frame update
    public Vector3 posP; //Position du panier
    public Vector3 posB; //Position du ballon
    public double r = 0.5; //rayon du ballon
    public int but = 0;
    void Start()
    {

    }

    void Update()
    {
        posP = GameObject.FindGameObjectWithTag("panier").transform.position;
        posB = GameObject.FindGameObjectWithTag("ball").transform.position;

        if ((Math.Pow(posB.z - posP.z, 2) + Math.Pow(posB.x, 2) + Math.Pow(posB.y - posP.y, 2)) <= Math.Pow(r, 2))
            Debug.Log("buuuuuuuuuuuuuut");

    }
}

