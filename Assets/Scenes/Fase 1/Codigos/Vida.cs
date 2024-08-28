using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Vida : MonoBehaviour
{
    public int health = 1;

    float invul = 0;

    int correctlayer;

    private void Start()
    {
         correctlayer = gameObject.layer;
    }

    private void OnParticleCollision(GameObject other)
    {
      
            health--;
            invul = 2f;
        gameObject.layer = 8;

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {

        health--;
        invul = 2f;
        gameObject.layer = 8;

    }
    private void Update()
    {
       invul -= Time.deltaTime;
        if(invul <= 0)
        {
            gameObject.layer = correctlayer;
        }


        if (health <= 0)
        {
            Die();
        }
   
    }
    void Die()
    {
        Destroy(gameObject);

    }
}
