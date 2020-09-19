using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public float velocidadeMaxima;
    public float forca;
    public bool IsGrounded;
    public bool GameOver;
    public static bool colidiu;
    private int i;
    public Text TextScore;
    public int Score = 0;

    // Update is called once per frame
    void FixedUpdate()
    {
        //ANDAR

        Rigidbody2D vetor = GetComponent<Rigidbody2D>();
        float movimento = Input.GetAxis("Horizontal");
        vetor.velocity = new Vector2(movimento * velocidadeMaxima, GetComponent<Rigidbody2D>().velocity.y);

        //VIRAR O PERSONAGEM

        if (movimento < 0)
        {
            GetComponent<SpriteRenderer>().flipX = true;
        }else if (movimento > 0)
        {
            GetComponent<SpriteRenderer>().flipX = false;
        }

        //Animacao

        //if (movimento > 0 || movimento < 0)
        //{
        //    GetComponent<Animator>().SetBool("andar", true);
        //}
       // else
       // {
        //    GetComponent<Animator>().SetBool("andar", false);
        //}

        //PULAR

        //Seta para Cima
        if (Input.GetKeyDown(KeyCode.UpArrow) && IsGrounded)
        {
            GetComponent<Rigidbody2D>().AddForce(new Vector4(0, forca*2));
        }
        //Tecla Espaço
        else if (Input.GetKeyDown(KeyCode.Space) && IsGrounded)
        {
            GetComponent<Rigidbody2D>().AddForce(new Vector4(0, forca*2));
        }
        //Tecla W
        else if (Input.GetKeyDown(KeyCode.W) && IsGrounded)
        {
            GetComponent<Rigidbody2D>().AddForce(new Vector4(0, forca*2));
        }
       // if (IsGrounded)
       // {
        //    GetComponent<Animator>().SetBool("pular", false);
       // }else{
        //    GetComponent<Animator>().SetBool("pular", true);
        //}
        if (GameOver)
        {
            Destroy(gameObject);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
            //Verifica Chão
            if (collision.gameObject.CompareTag("Plataforma"))
            {
                IsGrounded = true;
            }
        if (collision.gameObject.CompareTag("Bloco Morte"))
        {
            GameOver = true;
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Plataforma"))
        {
            IsGrounded = false;
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
         if (other.gameObject.CompareTag("Identificador Colisão"))
        {
            colidiu = true;
            Destroy(other.gameObject);
            Score += 10;
            TextScore.text = Score.ToString();
        }
    }
}