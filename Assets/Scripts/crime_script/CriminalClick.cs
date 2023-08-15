using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class CriminalClick : MonoBehaviour
{
    public AudioSource audioSoure;
    public GameObject chu;
    public GameObject chuC;
    public int cIndex = 0;
    public GameObject tt;

    public GameObject Hamster;
    public GameObject Turtle;
    public GameObject Dog;
    public GameObject Rabbit;
    public GameObject Frog;
    public GameObject Cat;
    public GameObject Hedgehog;
    public int i;
    public int check;
    public int tIndex = 0;
    public GameObject Crime;
    public GameObject Happy;
    public GameObject Sad;

    //���� ��ȭâ
    public GameObject hTalk1;
    public GameObject hTalk2;
    public GameObject hTalk3;
    public TMP_Text happyTalk;
    public TMP_Text happyTalk2;
    public TMP_Text happyTalk3;

    //���� ��ȭâ
    public GameObject sTalk1;
    public GameObject sTalk2;
    public GameObject sTalk3;
    public TMP_Text sadTalk;
    public TMP_Text sadTalk2;
    public TMP_Text sadTalk3;

    public GameObject[] criminalC;
    public GameObject[] criminalS;

    // add) end scene bool
    public static bool rslt;

    // Start is called before the first frame update
    void Start()
    {
        audioSoure = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    { 
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(pos, Vector2.zero, 0f);
            if (hit.collider != null)
            {
                GameObject click_obj = hit.transform.gameObject;
                Debug.Log(click_obj.name);
                if (click_obj.name == "ChuChu")
                {
                    tt.SetActive(true);
                    chu.SetActive(false);
                    chuC.SetActive(true);
                }
                if (click_obj.name == "ChuChuC")
                {
                    tt.SetActive(false);
                    chuC.SetActive(false);
                    chu.SetActive(true);
                }
                if (click_obj.name == "Hamster") //�ܽ��� Ŭ��
                {
                    Debug.Log(click_obj.name);
                 
                        for (i = 0; i < 7; i++)
                        {
                            criminalC[i].SetActive(false);
                        }
                        criminalC[0].SetActive(true);
                    check = 0;
                }
                if (click_obj.name == "HamsterC") //�ܽ��� ���
                {
                    criminalC[0].SetActive(false);
                    Hamster.SetActive(true);
                    check = 10;
                }
                if (click_obj.name == "Turtle") //�ź��� Ŭ��
                {
                    Debug.Log(click_obj.name);
                    for (i = 0; i < 7; i++)
                    {
                        criminalC[i].SetActive(false);
                    }
                    criminalC[1].SetActive(true);
                    check = 1;
                }
                if (click_obj.name == "TurtleC") //�ź��� ���
                {
                    criminalC[1].SetActive(false);
                    Turtle.SetActive(true);
                    check = 10;
                }
                if (click_obj.name == "Dog") //������ Ŭ��
                {
                    Debug.Log(click_obj.name);
                    for (i = 0; i < 7; i++)
                    {
                        criminalC[i].SetActive(false);
                    }
                    criminalC[2].SetActive(true);
                    check = 2;
                }
                if (click_obj.name == "DogC") //������ ���
                {
                    criminalC[2].SetActive(false);
                    Dog.SetActive(true);
                    check = 10;
                }
                if (click_obj.name == "Rabbit") //�䳢 Ŭ��
                {
                    Debug.Log(click_obj.name);
                    for (i = 0; i < 7; i++)
                    {
                        criminalC[i].SetActive(false);
                    }
                    criminalC[3].SetActive(true);
                    check = 3;
                }
                if (click_obj.name == "RabbitC") //�䳢 ���
                {
                    criminalC[3].SetActive(false);
                    Rabbit.SetActive(true);
                    check = 10;
                }
                if (click_obj.name == "Frog") //������ Ŭ��
                {
                    Debug.Log(click_obj.name);
                    for (i = 0; i < 7; i++)
                    {
                        criminalC[i].SetActive(false);
                    }
                    criminalC[4].SetActive(true);
                    check = 4;
                }
                if (click_obj.name == "FrogC") //������ ���
                {
                    criminalC[4].SetActive(false);
                    Frog.SetActive(true);
                    check = 10;
                }
                if (click_obj.name == "Cat") //������ Ŭ��
                {
                    Debug.Log(click_obj.name);
                    for (i = 0; i < 7; i++)
                    {
                        criminalC[i].SetActive(false);
                    }
                    criminalC[5].SetActive(true);
                    check = 5;
                }
                if (click_obj.name == "CatC") //������ ���
                {
                    criminalC[5].SetActive(false);
                    Cat.SetActive(true);
                    check = 10;
                }
                if (click_obj.name == "Hedgehog") //������ġ Ŭ��
                {
                    Debug.Log(click_obj.name);
                    for (i = 0; i < 7; i++)
                    {
                        criminalC[i].SetActive(false);
                    }
                    criminalC[6].SetActive(true);
                    check = 6;
                }
                if (click_obj.name == "HedgehogC") //������ġ ���
                {
                    criminalC[6].SetActive(false);
                    Hedgehog.SetActive(true);
                    check = 10;
                }

                if (click_obj.name == "Talk") //���� ��ȭâ
                {
                    Debug.Log(click_obj.name);
                    sTalk1.SetActive(false);
                    sTalk2.SetActive(true);
                    sadTalk2.text = criminalS[check].name + "는...";
                }
                if (click_obj.name == "Talk (1)")
                {
                    sTalk2.SetActive(false);
                    sTalk3.SetActive(true);
                    sadTalk3.text = "범인이 아니야";
                    rslt = false;
                    SceneManager.LoadScene("EndScene");
                }

                if (click_obj.name == "TalkH") //���� ��ȭâ
                {
                    Debug.Log(click_obj.name);
                    hTalk1.SetActive(false);
                    hTalk2.SetActive(true);
                    happyTalk2.text = criminalS[check].name + "는...";
                }
                if (click_obj.name == "TalkH(1)")
                {
                    hTalk2.SetActive(false);
                    hTalk3.SetActive(true);
                    happyTalk3.text = "범인이 맞아!!";
                    rslt = true;
                    SceneManager.LoadScene("EndScene");
                }
            }
        }
    }
   

    public void Next() //���ΰ˰� ��ư Ŭ�� -> ȭ�� �̵�
    {
       if (check == 0)
       {
            Crime.SetActive(false);
            Sad.SetActive(true);
            criminalS[0].SetActive(true);
            sadTalk.text = criminalS[0].name + "를 골랐구나..";
       }
       if (check == 1)
       {
            Crime.SetActive(false);
            Sad.SetActive(true);
            criminalS[1].SetActive(true);
            sadTalk.text = criminalS[1].name + "를 골랐구나..";
       }
       if (check == 2)
       {
            Crime.SetActive(false);
            Sad.SetActive(true);
            criminalS[2].SetActive(true);
            sadTalk.text = criminalS[2].name + "를 골랐구나..";
       }
       if (check == 3)
       {
            Crime.SetActive(false);
            Sad.SetActive(true);
            criminalS[3].SetActive(true);
            sadTalk.text = criminalS[3].name + "를 골랐구나..";
       }
       if (check == 4)
       {
            Crime.SetActive(false);
            Happy.SetActive(true);
            happyTalk.text = criminalS[4].name + "를 골랐구나..";
       }
       if (check == 5)
       {
            Crime.SetActive(false);
            Sad.SetActive(true);
            criminalS[5].SetActive(true);
            sadTalk.text = criminalS[5].name + "를 골랐구나..";
       }
       if (check == 6)
       {
            Crime.SetActive(false);
            Sad.SetActive(true);
            criminalS[6].SetActive(true);
            sadTalk.text = criminalS[6].name + "를 골랐구나..";
       }  
    }
}
