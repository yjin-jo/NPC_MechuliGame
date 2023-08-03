using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ObjectClicker : MonoBehaviour
{
    public GameManagerM gameManager;
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
                if(click_obj.name != "Success" && click_obj.name != "SuccessOk" && click_obj.name != "Fail" && click_obj.name != "FailOk" && click_obj.name != "SFBackGround") //물고기 눌렀을때
                {
                    Debug.Log(click_obj.name);
                    click_obj.SetActive(false); //오브젝트 비활성화
                    //Destroy(click_obj);
                    gameManager.point += 1; //포인트 획득
                }
               
                if (gameManager.stageIndex == 0 && gameManager.point >= 15 && gameManager.GameTime1 > 0.0f) //1라운드 성공
                {
                    gameManager.Stages[0].SetActive(false);
                    gameManager.s.SetActive(true);
                    //gameManager.button1.SetActive(true); //버튼 등장
                    //gameManager.UISuccess.SetActive(true); //success뜨고 확인
                    //gameManager.UISFBackground.SetActive(true);
                    Time.timeScale = 0;                   
                }

                if (gameManager.stageIndex == 1 && gameManager.point >= 20 && gameManager.GameTime1 > 0.0f) //2라운드 성공
                {
                    gameManager.Stages[1].SetActive(false);
                    gameManager.s2.SetActive(true);
                   // gameManager.button2.SetActive(true); //버튼 등장
                    //gameManager.UISuccess.SetActive(true); //success뜨고 확인
                    //gameManager.UISFBackground.SetActive(true);
                    Time.timeScale = 0;        
                }
                if (gameManager.stageIndex == 2 && gameManager.point >= 30 && gameManager.GameTime1 > 0.0f) //3라운드 성공
                {
                    gameManager.button3.SetActive(true); //버튼 등장
                    gameManager.UISuccess.SetActive(true); //success뜨고 확인
                    //gameManager.UISFBackground.SetActive(true);
                    Time.timeScale = 0;                    
                }
            }
        }
    }
}
