using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fantasma : MonoBehaviour
{
    float speed = 5;
    bool cima = true;
    bool baixo = false;
    public int danoInflingido;

    void Update()
    {
        if(cima == true)
      {
        transform.position = transform.position + (Vector3.up * speed * Time.deltaTime);
        if(transform.position.y >= 1.9)
        {
            baixo = true; 
            cima = false;
        }
      }

      if(baixo == true)
      {
        transform.position = transform.position + (Vector3.down * speed * Time.deltaTime);
        if(transform.position.y <= -1.17)
        {
            cima = true; 
            baixo = false;
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
