using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{

public void cargarEscenaPlayer()
{
    SceneManager.LoadScene("SampleScene");
}

public void cargarEscenaSelectLvl()
{
    SceneManager.LoadScene("SelectLevel");
}

public void cargarEscenaIALvl1()
{
    SceneManager.LoadScene("Level1");
}

public void cargarEscenaIALvl2()
{
    SceneManager.LoadScene("Level2");
}

public void cargarEscenaIALvl3()
{
    SceneManager.LoadScene("Level3");
}

}
