using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
    public void NextLevelBtn()
    {
        Time.timeScale = 1.0F;
        SceneManager.LoadScene("pic_GameScene2");
    }
}
