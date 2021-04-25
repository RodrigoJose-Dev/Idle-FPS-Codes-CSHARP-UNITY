using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{

    public GameObject panelPause;
                
    private void Update()
    {
        //esc na primeira vez vai abrir o painel de pause e na segunda vez vai fechar o painel
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Pause();
        }

    }
        
    void Pause() //no pause vai ativar o painel e o cursor
    {
        panelPause.SetActive(true);
        Time.timeScale = 0f;
        Cursor.visible = true;
    }

    //aplicando função de retornar ao button return
    public void ReturnBtn()
    {
        panelPause.SetActive(false);
        Time.timeScale = 1f;
        Cursor.visible = false;
    }

}
