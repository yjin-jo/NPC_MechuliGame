using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Setting : MonoBehaviour
{
    public GameObject Eggs;
    public GameObject Settings;
    public GameObject Sounds; 
    public GameObject ex;

    public Button btn1;
    public Button btn2;
    public Button btn3;
    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            Vector2 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(pos, Vector2.zero, 0f);
            if (hit.collider != null)
            {
                GameObject click_obj = hit.transform.gameObject;
                if (click_obj.name == "ex") //설명창 닫기
                {
                    ex.SetActive(false);
                    Debug.Log(click_obj.name);
                }
            }
        }
    }
    
    public void Egg()
    {
        Debug.Log("egg");
        Eggs.SetActive(true);

        btn1.interactable = false; //버튼 비활성화
        btn2.interactable = false;
        btn3.interactable = false;
    }

    public void Set()
    {
        Settings.SetActive(true);

        btn1.interactable = false; //버튼 비활성화
        btn2.interactable = false;
        btn3.interactable = false;
    }

    public void Sound()
    {
        Sounds.SetActive(true);

        btn1.interactable = false; //버튼 비활성화
        btn2.interactable = false;
        btn3.interactable = false;
    }

    public void Back()
    {
        Eggs.SetActive(false);
        Settings.SetActive(false);
        Sounds.SetActive(false);

        btn1.interactable = true; //버튼 활성화
        btn2.interactable = true;
        btn3.interactable = true;
    }

    public void ExplainOn() //설정-> 게임설명
    {
        ex.SetActive(true);
    }

    public void Retry() //설정 -> 다시하기
    {
        SceneManager.LoadScene("SampleScene");
    }
}
