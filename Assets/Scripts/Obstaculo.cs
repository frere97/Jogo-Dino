using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstaculo : MonoBehaviour
{
    Rigidbody2D rb;
    public Vector2 Velocidade = new Vector2(0f, 0f);

    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
        rb.velocity = Velocidade;
    }

    private void FixedUpdate()
    {
        if (this.transform.position.x < -20)
        {
            Destroy(this.gameObject);
        }
    }
}
