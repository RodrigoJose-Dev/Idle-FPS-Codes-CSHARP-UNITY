using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    //referenciando audio source
    AudioSource audioScr;

    //volume da musica
    private float musicVol = 0.5f;

    private void Start()
    {
        audioScr = GetComponent<AudioSource>(); //pegando componentes de audio source
    }

    private void Update()
    {
        //o volume de audio source receberá a variável musicVol
        audioScr.volume = musicVol;
    }

    //passar vol pro slider do gameobject
    public void SetVol(float vol)
    {
        musicVol = vol;
    }

}
