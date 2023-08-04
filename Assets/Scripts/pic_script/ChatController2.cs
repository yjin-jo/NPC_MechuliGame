using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChatController2 : MonoBehaviour
{
    public Text ChatText; // 실제 채팅이 나오는 텍스트
    public Text CharacterName; // 캐릭터 이름이 나오는 텍스트


    /* public List<KeyCode> skipButton; // 대화를 빠르게 넘길 수 있는 키 */

    public string writerText = "";

    /* bool isButtonClicked = false; */

    void Start()
    {
        StartCoroutine(TextPractice());
    }

    /* void Update()
    {
        foreach (var element in skipButton) // 버튼 검사
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

        //텍스트 타이핑 효과
        for (a = 0; a < narration.Length; a++)
        {
            writerText += narration[a];
            ChatText.text = writerText;
            yield return null;
        }

        //키를 다시 누를 떄 까지 무한정 대기
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
        yield return StartCoroutine(NormalChat("추추", "당근아 집에 있어?"));
        yield return StartCoroutine(NormalChat("당근이", "추추 오랜만이네 무슨 일 있어?"));
        yield return StartCoroutine(NormalChat("추추", "당근아 나 usb를 도둑맞았어.."));
        yield return StartCoroutine(NormalChat("당근이", "정말 큰일이네.. 내가 좀 도와줄 수 있는데"));
        yield return StartCoroutine(NormalChat("당근이", "내가 같은 그림 찾기 게임을 하고 있었는데 날 이기면 힌트를 줄게!"));
        yield return StartCoroutine(NormalChat("당근이", "게임은 총 2레벨까지 있고, 처음 보이는 카드를 잘 기억해두었다가 시간 내에 모든 짝을 다 맞추면 되는 게임이야"));
        yield return StartCoroutine(NormalChat("당근이", "제한 시간이 다 지나면 실패, 다시 하기를 누르면 레벨 1부터 다시 시작되니 주의하자!"));
    }
}
