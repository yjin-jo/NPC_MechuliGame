using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManagerM : MonoBehaviour
{
    public Setting_Miu set;
    public GameObject s;
    public GameObject s2;

    public float GameTime1 = 25;
    public float GameTime2 = 20;
    public float GameTime3 = 15;
    public int point;
    public Image[] UIseaweed;
    public TMP_Text UITimer;
    public TMP_Text UITimer2;
    public TMP_Text UITimer3;
    public GameObject[] Stages;
    public int stageIndex;
    public GameObject Story;
    public GameObject UISuccess;
    public GameObject UISuccessOk;
    public GameObject UIFail;
    public GameObject UIFailOk;
    public GameObject UISFBackground;
    public Image[] Level;
    public GameObject button1;
    public GameObject button2;
    public GameObject button3;
    public GameObject reButton1;
    public GameObject reButton2;
    public GameObject reButton3;
    private void Awake()
    {
        Debug.Log("gameIndex����");
        //GameObject.Find("Main_MainManager").GetComponent<Main_MainManager>().gameIndex = 0;
    }

    private void Start()
    {
        GameTime1 = 25;
        Debug.Log("�ٽ� ����");
    }
    public void NextStage() //���� ���������� �Ѿ��
    {
        if (stageIndex < Stages.Length - 1)
        {
            UISuccess.SetActive(false); //���� ���� ui ������
                                        //UISuccessOk.SetActive(false);
                                        //UISFBackground.SetActive(false);
            button1.SetActive(false);
            button2.SetActive(false);
            button3.SetActive(false);
            s.SetActive(false);
            s2.SetActive(false);

            Stages[stageIndex].SetActive(false);
            stageIndex++;
            Time.timeScale = 1;
            Stages[stageIndex].SetActive(true);
        }
        else
        {
            stageIndex++;
            Time.timeScale = 0;
            Debug.Log("���� Ŭ����!");
        }
        point = 0;
    }
    public void ReturnStage()
    {
        SceneManager.LoadScene("GameOver_Mieu"); //���� ȭ������ �̵�
    }

    public void NextHint()
    {
        UISuccess.SetActive(false);
        //UISuccessOk.SetActive(false);
        //UISFBackground.SetActive(false);
        button3.SetActive(false);
        Stages[stageIndex].SetActive(false);

        SceneManager.LoadScene("Hint_Mieu"); //��Ʈâ���� �̵�
    }


    // Update is called once per frame
    public void Update()
    {
        if (stageIndex == 0) //1����
        {
            if ((int)GameTime1 == 0) //1���� ����
            {
                SceneManager.LoadScene("GameOver_Mieu"); //���� ȭ������ ��ȯ
            }
            else //�ð� �帣��...
            {
                GameTime1 -= Time.deltaTime;
                //Debug.Log((int)GameTime1);
                UITimer.text = "" + (int)GameTime1;
            }
        }
        if (stageIndex == 1) //2����
        {
            if ((int)GameTime2 == 0) //2���� ����
            {
                SceneManager.LoadScene("GameOver_Mieu"); //���� ȭ������ ��ȯ          
            }
            else
            {
                GameTime2 -= Time.deltaTime;
                //Debug.Log((int)GameTime1);
                UITimer2.text = "" + (int)GameTime2;
            }
        }
        if (stageIndex == 2) //3����
        {
            if ((int)GameTime3 == 0) //3���� ����
            {
                SceneManager.LoadScene("GameOver_Mieu"); //���� ȭ������ ��ȯ               
            }
            else
            {
                GameTime3 -= Time.deltaTime;
                //Debug.Log((int)GameTime1);
                UITimer3.text = "" + (int)GameTime3;
            }
        }
    }
}
