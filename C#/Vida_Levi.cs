using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vida_Levi : MonoBehaviour
{
    public int MaxVida;
    public int AtualVida;


    void Start()
    {
        AtualVida = MaxVida;
    }

    public void Dano(int quantidadeDeDano)
    {
        AtualVida -= quantidadeDeDano;
        if(AtualVida<= 0)
        {
            Debug.Log("Game Over");
        }
    }
}
