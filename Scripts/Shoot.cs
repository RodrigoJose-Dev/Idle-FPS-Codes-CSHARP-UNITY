using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{

    public static Shoot instance;

    public AudioSource shootSound;

    private void Awake()
    {
        instance = this;
    }

    private float distancia = 50f; //distancia do raio
    public bool canDamage = false; //permitir atirar ou não
        
    private void Update()
    {
        
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mouse = Input.mousePosition;  //pega posicao mouse
            Ray raio = Camera.main.ScreenPointToRay(mouse);

            RaycastHit2D hit = Physics2D.Raycast(raio.origin, raio.direction, distancia);

            Debug.DrawRay(raio.origin, raio.direction * distancia, Color.red); //Desenha O Raio Para ver se está funcionado

            shootSound.Play();

            if (hit.collider != null)
            {
               
                if (canDamage == true)
                {
                    //checar a tag do inimigo
                    if (hit.collider.gameObject.CompareTag("Enemy"))
                    {
                        hit.collider.GetComponent<Enemies>().DeathState();  //abater inimigo
                        Score.instance.scoreCounter++; //contando mais 1 ponto na pontuacao
                    }
                }
            }


        }

    }

    


}
