using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

[System.Serializable] //���� ���� class�� ������ �� �ֵ��� ����. 
public class pic_Dialogue
{
    [TextArea]//���� ���� ���� �� �� �� �ְ� ����
    public string dialogue;
    public string name;
    public Sprite cg; // ��ü�� �̹���
}

public class ChatController : MonoBehaviour
{
    public GameObject yes;
    public GameObject no;


    //SerializeField : inspectorâ���� ���� ������ �� �ֵ��� �ϴ� ������.
    [SerializeField] private SpriteRenderer sprite_StandingCG; //ĳ���� �̹���(YK)�� �����ϱ� ���� ����
    [SerializeField] private Text txt_Dialogue; // �ؽ�Ʈ�� �����ϱ� ���� ����
    [SerializeField] private Text txt_Name;

    private int count = 0; //��簡 �󸶳� ����ƴ��� �˷��� ����

    [SerializeField] private pic_Dialogue[] dialogue;

    void Start()
    {
        NextDialogue();
    }

    private void NextDialogue()
    {
        //ù��° ���� ù��° cg���� ��� ���� cg�� ����Ǹ鼭 ȭ�鿡 ���̰� �ȴ�.
        if (count == dialogue.Length)
        {
            SceneManager.LoadScene("pic_Methodscene");
            return;
        }

        txt_Dialogue.text = dialogue[count].dialogue;
        txt_Name.text = dialogue[count].name;
        sprite_StandingCG.sprite = dialogue[count].cg;
        count++; //���� ���� cg�� �������� 
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
            // ���콺 Ŭ�� ��ġ�� ī�޶� ��ũ�� ��������Ʈ�� �����մϴ�.
            Vector2 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            // Raycast�Լ��� ���� �ε�ġ�� collider�� hit�� ���Ϲ޽��ϴ�.
            RaycastHit2D hit = Physics2D.Raycast(pos, Vector2.zero);

            if (hit.collider != null)
            {
                // � ������Ʈ���� �α׸� ����ϴ�.
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
