using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class NextScenario4 : MonoBehaviour
{
    // scene4->talking1 ��� �̵��ع�����
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("click the scene4!!!");
            SceneManager.LoadScene("ChuChuTalk");
        }
    }
}
