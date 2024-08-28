using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InimigoAtirar : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform firePoint;
    public ParticleSystem Jugre;
    public int Tiros = 1;

    public float Delay = 1f;
    float Cooldown = 0;

    void Update()
    {
        Cooldown -= Time.deltaTime;
        if ( Cooldown <= 0)
        {
            Cooldown = Delay;
            Fire();
        }
    }
    void Fire()
    {
      Jugre.Emit(Tiros);
    }
}