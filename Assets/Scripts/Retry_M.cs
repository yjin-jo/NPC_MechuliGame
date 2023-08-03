using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Retry_M : MonoBehaviour
{
    public void ReturnStage()
    {
        SceneManager.LoadScene("GameOver_Mieu"); //실패 화면으로 이동
    }
}
