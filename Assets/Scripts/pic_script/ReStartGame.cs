using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReStartGame : MonoBehaviour
{
    public void ReStartBtn()
    {
        SceneManager.LoadScene("pic_GameScene");
    }
}
