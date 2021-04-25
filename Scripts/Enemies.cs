using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemies : MonoBehaviour
{
    
    public static Enemies instance;
    
    public float vel;
    private float timer;
    public int damage = 10;
            
    public Transform spot;

    private void Awake()
    {
        instance = this;
    }

    private void Update()
    {

        timer += Time.deltaTime;

        // movetowards recebe a posição do objeto, até onde ele quer ir e a velocidade
        transform.position = Vector2.MoveTowards(transform.position, spot.position, vel * Time.deltaTime);

        if (transform.position == spot.transform.position && timer >= 2)
        {
            PlayerHealth.instance.damageReceived += damage;
            timer = 0;
        }
    }
        
    public void DeathState()
    {
        Destroy(gameObject);
    }
        
    
}
