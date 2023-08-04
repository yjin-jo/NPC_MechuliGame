using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

[System.Serializable] //직접 만든 class에 접근할 수 있도록 해줌. 
public class pic_Dialogue
{
    [TextArea]//한줄 말고 여러 줄 쓸 수 있게 해줌
    public string dialogue;
    public string name;
    public Sprite cg; // 교체될 이미지
}

public class ChatController : MonoBehaviour
{
    public GameObject yes;
    public GameObject no;


    //SerializeField : inspector창에서 직접 접근할 수 있도록 하는 변수임.
    [SerializeField] private SpriteRenderer sprite_StandingCG; //캐릭터 이미지(YK)를 제어하기 위한 변수
    [SerializeField] private Text txt_Dialogue; // 텍스트를 제어하기 위한 변수
    [SerializeField] private Text txt_Name;

    private int count = 0; //대사가 얼마나 진행됐는지 알려줄 변수

    [SerializeField] private pic_Dialogue[] dialogue;

    void Start()
    {
        NextDialogue();
    }

    private void NextDialogue()
    {
        //첫번째 대사와 첫번째 cg부터 계속 다음 cg로 진행되면서 화면에 보이게 된다.
        if (count == dialogue.Length)
        {
            SceneManager.LoadScene("pic_Methodscene");
            return;
        }

        txt_Dialogue.text = dialogue[count].dialogue;
        txt_Name.text = dialogue[count].name;
        sprite_StandingCG.sprite = dialogue[count].cg;
        count++; //다음 대사와 cg가 나오도록 
    }

    public void Yes_clicked()
    {
        print("Yes_clicked");
        print(count); // count == 6
        yes.gameObject.SetActive(false);
        no.gameObject.SetActive(false);
        NextDialogue();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            // 마우스 클릭 위치를 카메라 스크린 월드포인트로 변경합니다.
            Vector2 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            // Raycast함수를 통해 부딪치는 collider를 hit에 리턴받습니다.
            RaycastHit2D hit = Physics2D.Raycast(pos, Vector2.zero);

            if (hit.collider != null)
            {
                // 어떤 오브젝트인지 로그를 찍습니다.
                Debug.Log(hit.collider.name);

                if (hit.collider.name == "Dialog Bar")
                {
                    if (count == 4)
                    {
                        yes.gameObject.SetActive(true);
                        no.gameObject.SetActive(true);
                        NextDialogue();
                    }

                    if (count < dialogue.Length && count != 5)
                    {
                        NextDialogue();
                    }
                    else if (count == 7)
                    {
                        NextDialogue();
                    }
                }
            }
        }
    }
}
