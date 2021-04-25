using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{

    public static PlayerHealth instance;
        
    public Text lifePoints;

    public int totalHealth = 100;
    public int damageReceived;
    public int currentHealth;

    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        currentHealth = totalHealth;
    }

    private void Update()
    {
                
        currentHealth = totalHealth - damageReceived;

        lifePoints.text = currentHealth.ToString();
               
    }
                
}
