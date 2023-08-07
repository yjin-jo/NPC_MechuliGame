using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pic_GetHint : MonoBehaviour
{
    public GameObject Hint; // ÈùÆ® ÀÌ¹ÌÁö
    public GameObject HintEnv; // ÈùÆ® ºÀÅõ
    //public Button btnHint; // ÈùÆ® º¸±â ¹öÆ°

    public void ShowHint()
    {
        Hint.gameObject.SetActive(true);
        HintEnv.gameObject.SetActive(false);
    }

    public void ShowHintEnv()
    {
        HintEnv.gameObject.SetActive(true);
    }
}

