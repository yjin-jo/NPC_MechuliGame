using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChatController2 : MonoBehaviour
{
    public Text ChatText; // ���� ä���� ������ �ؽ�Ʈ
    public Text CharacterName; // ĳ���� �̸��� ������ �ؽ�Ʈ


    /* public List<KeyCode> skipButton; // ��ȭ�� ������ �ѱ� �� �ִ� Ű */

    public string writerText = "";

    /* bool isButtonClicked = false; */

    void Start()
    {
        StartCoroutine(TextPractice());
    }

    /* void Update()
    {
        foreach (var element in skipButton) // ��ư �˻�
        {
            if (Input.GetKeyDown(element))
            {
                isButtonClicked = true;
            }
        }
    }*/


    IEnumerator NormalChat(string narrator, string narration)
    {
        int a = 0;
        CharacterName.text = narrator;
        writerText = "";

        //�ؽ�Ʈ Ÿ���� ȿ��
        for (a = 0; a < narration.Length; a++)
        {
            writerText += narration[a];
            ChatText.text = writerText;
            yield return null;
        }

        //Ű�� �ٽ� ���� �� ���� ������ ���
        while (true)
        {
            if (Input.GetMouseButtonDown(0))
            {
                break;
            }
            yield return null;
        }
    }

    IEnumerator TextPractice()
    {
        yield return StartCoroutine(NormalChat("����", "��پ� ���� �־�?"));
        yield return StartCoroutine(NormalChat("�����", "���� �������̳� ���� �� �־�?"));
        yield return StartCoroutine(NormalChat("����", "��پ� �� usb�� ���ϸ¾Ҿ�.."));
        yield return StartCoroutine(NormalChat("�����", "���� ū���̳�.. ���� �� ������ �� �ִµ�"));
        yield return StartCoroutine(NormalChat("�����", "���� ���� �׸� ã�� ������ �ϰ� �־��µ� �� �̱�� ��Ʈ�� �ٰ�!"));
        yield return StartCoroutine(NormalChat("�����", "������ �� 2�������� �ְ�, ó�� ���̴� ī�带 �� ����صξ��ٰ� �ð� ���� ��� ¦�� �� ���߸� �Ǵ� �����̾�"));
        yield return StartCoroutine(NormalChat("�����", "���� �ð��� �� ������ ����, �ٽ� �ϱ⸦ ������ ���� 1���� �ٽ� ���۵Ǵ� ��������!"));
    }
}
