using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetHint : MonoBehaviour
{
    public GameObject Hint; // ��Ʈ �̹���
    public Button btnHint; // ��Ʈ ���� ��ư
    public string newhint; // ȹ���� ��Ʈ

    void Start()
    {
        Hint.gameObject.SetActive(false);
        btnHint.onClick.AddListener(ShowHint);
    }

    public void HintButton_clicked()
    {
        newhint = "rjqnrdlsms qjadlsdl dkslek.";
        DataManager.instance.nowPlayer.hints.Add(newhint); // ȹ���� ��Ʈ�� ����Ʈ�� �߰�
        newhint += "\n";
        print(newhint);
        DataManager.instance.SaveData();
    }

    void ShowHint()
    {
        Hint.gameObject.SetActive(true);
    }
}

