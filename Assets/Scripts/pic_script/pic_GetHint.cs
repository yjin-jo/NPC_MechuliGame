using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pic_GetHint : MonoBehaviour
{
    public GameObject Hint; // ��Ʈ �̹���
    public GameObject HintEnv; // ��Ʈ ����
    //public Button btnHint; // ��Ʈ ���� ��ư

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

