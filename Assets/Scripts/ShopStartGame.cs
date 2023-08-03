using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class ShopStartGame : MonoBehaviour
{
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            // 깃허브 예시 주석
            // 게임 장면으로 넘어가기
            Debug.Log("click rule!!!");
            SceneManager.LoadScene("ShopGameScene");
        }
    }

}
