using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody2D rb;
    public Vector2 jumpForce = new Vector2 (0f, 500f);
    bool taNoChao;


    void Start()
    {

    }

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space) && taNoChao)
        {
            rb.AddForce(jumpForce);
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.name == "chao")
        {
            taNoChao = true;
        }

        if (collision.gameObject.GetComponent<Obstaculo>())
        {
            Destroy(this.gameObject);
        }

    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if(collision.gameObject.name == "chao")
        {
            taNoChao = false;
        }
    }
}
