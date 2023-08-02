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
                if (click_obj.name == "Talk") //대화
                {
                    Debug.Log(click_obj.name);
                    if(i == 0)
                    {
                        textN.text = "추추";
                        textT.text = "다름이 아니라, 누가 내 usb를 가져가서 찾는중이야";
                    }
                    if (i == 1)
                    {
                        ChuChu.SetActive(false);
                        Mieu.SetActive(true);
                        textN.text = "미유";
                        textT.text = "음 내가 범인을 본 것 같기도..?";
                    }
                    if (i == 2)
                    {
                        ChuChu.SetActive(true);
                        Mieu.SetActive(false);
                        textN.text = "추추";
                        textT.text = "헉 정말?? 나 좀 도와줘!!";
                    }
                    if (i == 3)
                    {
                        ChuChu.SetActive(false);
                        Mieu.SetActive(true);
                        textN.text = "미유";
                        textT.text = "그래 좋아 대신 네가 내 낚시를 먼저 도와주면 힌트를 줄게!";
                    }
                    if (i == 4)
                    {
                        textN.text = "미유";
                        textT.text = "게임 방법은 간단해, 제한 시간 내에 화면 속 물고기를 모두 터치하면 되는 게임이야 쉽지??";
                    }
                    if (i == 5)
                    {
                        textN.text = "미유";
                        textT.text = "게임 레벨은 총 3레벨까지 있고, 레벨마다 제한 시간이 달라질 거야";
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
