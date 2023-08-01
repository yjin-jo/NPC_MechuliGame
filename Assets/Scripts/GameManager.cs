using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public float currentTime = 0.0f;
    private bool isTimerRunning = false;

    public float startTime = 5;
    public int score = 0;
    public int check = 0;
    public int stageIndex;
    public bool flag = true;

    public GameObject[] Stages;
    public Sprite[] Levels;

    public GameObject Next;
    public GameObject Success;
    public GameObject Rule;
    public GameObject Canvas;

    public float setTime;
    public Text countdownText;
    public Text scoreText;
    public Text stageText;
    public GameObject level;


    void Awake()
    {
        currentTime = 0.0f;
        isTimerRunning = false;
    }
    void Start()
    {
        Rule.SetActive(true);
        isTimerRunning = true;

        Next.SetActive(false);
        countdownText.text = "남은 시간 : " + Mathf.Round(setTime).ToString() + "초";
        scoreText.text = "점수 : " + score.ToString();
        level.GetComponent<Image>().sprite = Levels[stageIndex];

        Next.SetActive(false);
        Success.SetActive(false);
        Stages[0].SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
       if (isTimerRunning)
        {
            Debug.Log("게임 경과 시간 :"+Time.time);
            Debug.Log("current Time: "+currentTime);
            currentTime += Time.deltaTime;
            if (currentTime >= startTime)
            {
                Rule.SetActive(false);
                Canvas.SetActive(true);
                Stages[0].SetActive(true);
                // 타이머 종료
                isTimerRunning = false;
            }
        }

        if (setTime > 0)
            setTime -= Time.deltaTime;
        else if (setTime <= 0)
        {
            SceneManager.LoadScene("FailScene");
            stageIndex = 0;
        }
        countdownText.text = "남은 시간 : " + Mathf.Round(setTime).ToString() + "초";
        scoreText.text = "점수 : " + score.ToString();
        level.GetComponent<Image>().sprite = Levels[stageIndex];

        if (flag)
        {
            if (stageIndex == 0)
                check = 1;
            else if (stageIndex == 1)
                check = 2;
            else if (stageIndex == 2)
                check = 3;

            if (check == score)
            {
                flag = false;
                Time.timeScale = 0;
                Next.SetActive(true);
                Success.SetActive(true);
            }
        }
    }

    public void NextStage()
    {
        Debug.Log("NextStage함수 실행");
        Next.SetActive(false);
        Success.SetActive(false);
        flag = true;
        score = 0;

        Time.timeScale = 1;

        if (stageIndex < Stages.Length - 1)
        {
            Stages[stageIndex].SetActive(false);
            stageIndex++;
            Stages[stageIndex].SetActive(true);

            if (stageIndex == 1)
                setTime = 20.0f;
            else if (stageIndex == 2)
                setTime = 10.0f;

            //stageText.text = "Level" + (stageIndex + 1).ToString();
            Debug.Log("현재 스테이지 : " + (stageIndex + 1));
        }
        else //Game Clear1
        {
            Debug.Log("게임 클리어");
            SceneManager.LoadScene("ClearScene");
        }

    }
}
