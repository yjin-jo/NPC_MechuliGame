using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Onclick_Set : MonoBehaviour
{
    public GameObject setBg;
    public GameObject main;
    public GameObject retry;
    public GameObject explain;
    public GameObject exit;
    public GameObject howtoplay;
    public GameObject temp;

    public void Set_clicked()
    {
        Time.timeScale = 0;
        temp.gameObject.SetActive(true);
        setBg.gameObject.SetActive(true);
        main.gameObject.SetActive(true);
        retry.gameObject.SetActive(true);
        explain.gameObject.SetActive(true);
        exit.gameObject.SetActive(true);
    }

    public void Main_clicked()
    {
        Time.timeScale = 1;
    }

    public void Retry_clicked()
    {
        Time.timeScale = 1;
    }

    public void Explain_clicked()
    {
        howtoplay.gameObject.SetActive(true);
        temp.gameObject.SetActive(true);
        setBg.gameObject.SetActive(false);
        main.gameObject.SetActive(false);
        retry.gameObject.SetActive(false);
        explain.gameObject.SetActive(false);
        exit.gameObject.SetActive(false);
    }

    public void HowToPlay_clicked()
    {
        Time.timeScale = 1;
        howtoplay.gameObject.SetActive(false);
        temp.gameObject.SetActive(false);
    }

    public void Exit_clicked()
    {
        Time.timeScale = 1;
        temp.gameObject.SetActive(false);
        setBg.gameObject.SetActive(false);
        main.gameObject.SetActive(false);
        retry.gameObject.SetActive(false);
        explain.gameObject.SetActive(false);
        exit.gameObject.SetActive(false);
    }
}
