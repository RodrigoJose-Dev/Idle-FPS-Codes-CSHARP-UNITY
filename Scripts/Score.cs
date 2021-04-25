using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static Score instance;

    public Text scoreText;
    public Text scoreTextGO;

    public int scoreCounter;

    private void Awake()
    {
        instance = this;
    }

    private void Update()
    {

        scoreText.text = scoreCounter.ToString();
        scoreTextGO.text = scoreCounter.ToString();

    }

}
