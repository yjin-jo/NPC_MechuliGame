using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Onclick_Guess : MonoBehaviour
{
    public Button GuessBtn;
    public GameObject exit;
    public GameObject myhint;
    public Text myhinttext;
    public GameObject temp;

    public void Guess_clicked()
    {
        Time.timeScale = 0;
        myhint.gameObject.SetActive(true);
        exit.gameObject.SetActive(true);
        temp.gameObject.SetActive(true);

        DataManager.instance.LoadData();
        ShowAllHints();
    }

    public void Exit_clicked()
    {
        Time.timeScale = 1;
        myhint.gameObject.SetActive(false);
        exit.gameObject.SetActive(false);
        temp.gameObject.SetActive(false);
    }

    private void ShowAllHints()
    {
        List<string> hints = DataManager.instance.nowPlayer.hints;
        string allHintsText = "";

        foreach (string hint in hints)
        {
            allHintsText += hint + "\n";
        }

        myhinttext.text = allHintsText;
    }
}
