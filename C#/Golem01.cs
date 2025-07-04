using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Golem01 : MonoBehaviour
{
    float speed = 3;
    bool direita = true;
    bool esquerda = false;
    Animator anim;
    public int danoInflingido;

    void Start()
    {
      anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
      if(direita== true)
      {
        transform.position = transform.position + (Vector3.right * speed * Time.deltaTime);
        transform.eulerAngles = new Vector2(0f, 0f);
        anim.SetBool("Run",true);
        if(transform.position.x > -1.6)
        {
            esquerda = true; 
            direita = false;
            anim.SetBool("Run",false);
        }
      }  
       if(esquerda == true)
      {
        transform.position = transform.position + (Vector3.left * speed * Time.deltaTime);
        transform.eulerAngles = new Vector2(0f, 180f);
        anim.SetBool("Run",true);
        if(transform.position.x < -7.6)
        {
            direita = true;
            esquerda  = false;
            anim.SetBool("Run",false);
        }
      }
    }
void OnTriggerEnter2D(Collider2D other)
   {
      if(other.gameObject.CompareTag("Player"))
      {
        other.gameObject.GetComponent<Vida_Levi>().Dano(danoInflingido);
      }
   }
}
