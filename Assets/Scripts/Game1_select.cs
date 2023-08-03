using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Game1_select : MonoBehaviour
{
    public void selectToAnotherScene()
    {
        SceneManager.LoadScene("MainScene 1");
    }
    public void selectToAnotherScene2()
    {
        SceneManager.LoadScene("MainScene 2");
    }
    public void selectToAnotherScene3()
    {
        SceneManager.LoadScene("obtainhintScene");
    }
}
