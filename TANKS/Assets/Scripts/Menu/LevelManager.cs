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

public void cargarEscenaIA()
{
    SceneManager.LoadScene("SceneIA");
}

}
