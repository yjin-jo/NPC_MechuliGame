using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetHint : MonoBehaviour
{
    public GameObject Hint; // ÈùÆ® ÀÌ¹ÌÁö
    public Button btnHint; // ÈùÆ® º¸±â ¹öÆ°
    public string newhint; // È¹µæÇÑ ÈùÆ®

    void Start()
    {
        Hint.gameObject.SetActive(false);
        btnHint.onClick.AddListener(ShowHint);
    }

    public void HintButton_clicked()
    {
        newhint = "rjqnrdlsms qjadlsdl dkslek.";
        DataManager.instance.nowPlayer.hints.Add(newhint); // È¹µæÇÑ ÈùÆ®¸¦ ¸®½ºÆ®¿¡ Ãß°¡
        newhint += "\n";
        print(newhint);
        DataManager.instance.SaveData();
    }

    void ShowHint()
    {
        Hint.gameObject.SetActive(true);
    }
}

