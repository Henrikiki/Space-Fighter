using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;

public class Movimento : MonoBehaviour
{
    public float Velocidade = 5f;
    public float Rotação = 1;
    public Rigidbody2D rdb;
    public SpriteRenderer Fogo;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(0, -2, 0);
    }

    // Update is called once per frame
    void Update()
    { }

    private void FixedUpdate()
    {
        Movimentos();
    }

    void Movimentos()
    {
        Vector3 pos = transform.position;
        pos.y += Input.GetAxis("Vertical") * Velocidade * Time.deltaTime;
        transform.position = pos;

   
        pos.x += Input.GetAxis("Horizontal") * Velocidade * Time.deltaTime;
        transform.position = pos;

        if (Input.GetAxis("Vertical") > 0)
        {
            Fogo.enabled = true;
        }
        else
        {
            Fogo.enabled = false;
        }
    }
}
