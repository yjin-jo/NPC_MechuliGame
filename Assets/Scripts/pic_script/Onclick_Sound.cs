using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Onclick_Sound : MonoBehaviour
{
    public GameObject soundBg;
    public GameObject bgSlider;
    public GameObject btnSlider;
    public GameObject exit;
    public GameObject temp;

    public void Sound_clicked()
    {
        Time.timeScale = 0;
        temp.gameObject.SetActive(true);
        soundBg.gameObject.SetActive(true);
        bgSlider.gameObject.SetActive(true);
        btnSlider.gameObject.SetActive(true);
        exit.gameObject.SetActive(true);
    }

    public void Exit_clicked()
    {
        Time.timeScale = 1;
        temp.gameObject.SetActive(false);
        soundBg.gameObject.SetActive(false);
        bgSlider.gameObject.SetActive(false);
        btnSlider.gameObject.SetActive(false);
        exit.gameObject.SetActive(false);
    }
}
