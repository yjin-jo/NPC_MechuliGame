using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class TalkScript : MonoBehaviour
{
    public Setting set;
    public TMP_Text textT;
    public TMP_Text textN;
    public GameObject St1;
    public GameObject St2;
    public GameObject Mieu;
    public GameObject ChuChu;

    public int i;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(pos, Vector2.zero, 0f);
            if (hit.collider != null)
            {
                GameObject click_obj = hit.transform.gameObject;
                if (click_obj.name == "Talk") //��ȭ
                {
                    Debug.Log(click_obj.name);
                    if(i == 0)
                    {
                        textN.text = "����";
                        textT.text = "�ٸ��� �ƴ϶�, ���� �� usb�� �������� ã�����̾�";
                    }
                    if (i == 1)
                    {
                        ChuChu.SetActive(false);
                        Mieu.SetActive(true);
                        textN.text = "����";
                        textT.text = "�� ���� ������ �� �� ���⵵..?";
                    }
                    if (i == 2)
                    {
                        ChuChu.SetActive(true);
                        Mieu.SetActive(false);
                        textN.text = "����";
                        textT.text = "�� ����?? �� �� ������!!";
                    }
                    if (i == 3)
                    {
                        ChuChu.SetActive(false);
                        Mieu.SetActive(true);
                        textN.text = "����";
                        textT.text = "�׷� ���� ��� �װ� �� ���ø� ���� �����ָ� ��Ʈ�� �ٰ�!";
                    }
                    if (i == 4)
                    {
                        textN.text = "����";
                        textT.text = "���� ����� ������, ���� �ð� ���� ȭ�� �� ����⸦ ��� ��ġ�ϸ� �Ǵ� �����̾� ����??";
                    }
                    if (i == 5)
                    {
                        textN.text = "����";
                        textT.text = "���� ������ �� 3�������� �ְ�, �������� ���� �ð��� �޶��� �ž�";
                    }
                    if (i == 5)
                    {
                        St1.SetActive(false);
                        St2.SetActive(true);
                    }
                    i++;
                }

            }
        }
    }

    public void yesBtn()
    {
        SceneManager.LoadScene("HowTo");
    }
}
