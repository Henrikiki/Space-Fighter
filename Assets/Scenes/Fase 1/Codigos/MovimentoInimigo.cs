using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentoInimigo : MonoBehaviour
{
    public float Velocidade = 2f;

    private void FixedUpdate()
    {
        Movimentos();
    }

    void Movimentos()
    {
        Vector3 pos = transform.position;
        pos.y -= Velocidade * Time.deltaTime;
        transform.position = pos;


    }
}

