using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            // ����� ���� �ּ�
            // ���� ������� �Ѿ��
            Debug.Log("click rule!!!");
            SceneManager.LoadScene("ShopGameScene");
        }
    }

}
