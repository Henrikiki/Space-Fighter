using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Atirar : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform firePoint;
    public ParticleSystem Jugre;

    public float Delay = 0.5f;
    float Cooldown = 0;

    void Update() 
    {
        Cooldown -= Time.deltaTime;
        if(Input.GetButton("Fire1") && Cooldown <=0)
        {
            Cooldown = Delay;
            Fire();
        }
    }
    void Fire()
    {
        Jugre.Emit(1);
    }
}