using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{

    [SerializeField] private GameObject ButtonPausa;
    [SerializeField] private GameObject PanelMenuPausa;

    public void Pause(){
        Time.timeScale = 0f;
        ButtonPausa.SetActive(false);
        PanelMenuPausa.SetActive(true);
    }

    public void Resume()
    {
        Time.timeScale = 1f;
        ButtonPausa.SetActive(true);
        PanelMenuPausa.SetActive(false);
    }

    public void Options()
    {
    
    }

    public void Quit()
    {
       SceneManager.LoadScene("MenuPrincipal"); 
    }
}
