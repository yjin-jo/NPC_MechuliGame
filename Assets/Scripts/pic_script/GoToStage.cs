using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToStage : MonoBehaviour
{
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //Time.timeScale = 1.0F;
            SceneManager.LoadScene("pic_GameScene");
        }
    }
}
