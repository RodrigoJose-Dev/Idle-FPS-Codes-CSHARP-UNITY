using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menuManager : MonoBehaviour
{
    //nome da cena a ser acessada
    public string sceneName;

    //painel
    public GameObject panel;

    //carregar cenas
    public void LoadScene()
    {
        SceneManager.LoadScene(sceneName);
    }

    //menu som
    public void SoundPanel() //abrir e fechar panel 
    {
        if (panel != null)
        {
            bool isActive = panel.activeSelf;

            panel.SetActive(!isActive);
        }
    }

    //recarregar mesma cena
    public void ReloadScene()
    {        
        SceneManager.LoadScene("Game");
    }
            
    //sair do jogo
    public void LeaveGame()
    {
        Application.Quit();
    }

}
