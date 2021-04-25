using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public static GameManager instance;
   
    // passar na array os inimigos
    public GameObject[] enemy;
    private int i = 0;

    //spawn timer e aceleração de wave
    public float spawnTime;
    public float elapsedTime;
    public int waveCounter;

    //paineis
    public GameObject panel;
    
    private void Awake()
    {
        instance = this;
        panel.SetActive(false);
    }

    private void Start()
    {
        Time.timeScale = 1f;

        GameObject _ = Instantiate(enemy[i]) as GameObject;
        
        i = GameObject.FindGameObjectsWithTag("Enemy").Length; //localizando objetos com tag "Enemy"
    }

    private void Update()
    {

        #region Tempo, contador, contador de wave, monster spawn

        //tempo sendo armazenado em elapsedTime
        elapsedTime += Time.deltaTime;

        //caso o tempo corrido for igual ao tempo de spawn, irá instanciar um inimigo
        if (elapsedTime >= spawnTime)
        {
            
            elapsedTime = 0;
                        
            GameObject _ = Instantiate(enemy[i]) as GameObject;

            i++;

            waveCounter++;

        }
    
        //caso ultrapasse o limite da array, ela voltará ao indíce 0
        if (i >= enemy.Length)
        {
            i = 0;
        }

        //contador de wave
        if (waveCounter == 2)
        {
            spawnTime -= 1;
            waveCounter = 0;
        }

        //fixar spawnTime
        if (spawnTime < 1)
        {
            spawnTime = 1f;
        }

        #endregion

        PlayerDeath();
                                
    }

        
    void PlayerDeath()
    {

        if (PlayerHealth.instance.currentHealth <= 0)
        {
            Time.timeScale = 0;
            PlayerHealth.instance.currentHealth = 0;
            panel.SetActive(true);
        }

    }

}
