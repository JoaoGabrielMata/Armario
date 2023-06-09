using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dano_Levi : MonoBehaviour
{
    public int danoInflingido;

    void OnTriggerEnter2D(Collider2D other)
   {
      if(other.gameObject.CompareTag("Monster"))
      {
        other.gameObject.GetComponent<VidaGolem>().Dano(danoInflingido);
      }
   }
}
