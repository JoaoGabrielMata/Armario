using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Threading;

public class Buton : MonoBehaviour
{
    Animator anim;
    private Transform pointA;
    public bool click;
    public float speed;
    
    void Start()
    {
        anim = GetComponent<Animator>();
        click = false;
        pointA = GameObject.FindGameObjectWithTag("point A").transform; 

    }

    public void Clicker()
    {
        click = true;
    }
    
    void Update()
    {
       if(click==true)
       {
            anim.SetBool("Click", true);
            transform.position = pointA.position;
       }
       if(transform.position == pointA.position)
       {
            transform.eulerAngles =  Vector3.Lerp(transform.eulerAngles, new Vector3(0f,0f,330) , speed*Time.deltaTime);
       }
    }
}
