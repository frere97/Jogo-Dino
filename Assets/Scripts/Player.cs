using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody2D rb;
    public Vector2 jumpForce = new Vector2 (0f, 500f);
    bool taNoChao;
    [SerializeField]float velocidade = 50f;
    AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space) && taNoChao)
        {
            audioSource.Play();
            rb.AddForce(jumpForce);
        }
    }

    private void FixedUpdate()
    {
        transform.Translate(new Vector2(Input.GetAxisRaw("Horizontal"), 0) * velocidade);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.name == "chao")
        {
            taNoChao = true;
        }

        if (collision.gameObject.GetComponent<Obstaculo>())
        {
            Morreu();
        }

    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if(collision.gameObject.name == "chao")
        {
            taNoChao = false;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<Obstaculo>())
        {
            Morreu();
        }

        if (collision.gameObject.GetComponent<Moeda>())
        {
            ColetaMoeda(1, collision);
        }
    }

    void Morreu()
    {
        GameManager.instance.PlayerTaVivo = false;
        Time.timeScale = 0;
        UI.instance.TurnOnReplayMenu();
        Destroy(this.gameObject);
    }

    void ColetaMoeda(int quantidade, Collider2D collision)
    {
        GameManager.instance.moedas += quantidade;
        Destroy(collision.gameObject);
    }
}
