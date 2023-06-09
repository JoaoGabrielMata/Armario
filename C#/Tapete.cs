using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tapete : MonoBehaviour
{
    private Transform pointB;
    public bool click; 

    void Start()
    {
        click = false;
        pointB = GameObject.FindGameObjectWithTag("point B").transform; 
    }

    public void Clicker()
    {
        click = true;
    }
    
    void Update()
    {
        if(click==true)
       {
            transform.position = pointB.position;
       }
    }
}
