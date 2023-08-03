using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ShopSelectProduct : MonoBehaviour
{
    Camera mainCamera;
    RectTransform rectTransform;
    Vector2 targetPosition;
    RaycastHit2D hit;

    //사야할 물건 목록
    //salmon, jamA, bread, cola, coffee, cupcake, meatball, yogurtS -->배열에 담기?
    public List<GameObject> PrdList = new List<GameObject>();
    public GameObject Pduct;
    public int cnt = 0;

    void MouseClickDown() // 마우스 클릭 좌표
    {
        if (Input.GetMouseButtonDown(0)) // 마우스 좌 클릭 시, 해당 위치 Raycast 정보 가져옴
        {
            Vector2 worldPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            hit = Physics2D.Raycast(worldPoint, Vector2.zero);

            BoolOnonSelected(); // 클릭 위치 오브젝트 감지 함수 호출
        }
    }
    void BoolOnonSelected() // 클릭 위치 오브젝트 감지
    {
        if (hit.collider != null) // Raycast 정보에 collider가 있다면 해당 오브젝트 위치 받아옴
        {
            //Vector2 targetPosition = GameObject.Find($"{hit.collider.name}").transform.position;
            targetPosition = hit.transform.position; // 해당오브젝트 위치
            CorrectUIName(); // 선택 표시 함수 호출
        }
        else // 없으면 
        {
            Debug.Log("선택된 상품오브젝트 없음");
        }
    }
    void CorrectUIName()
    {
        bool found = false;
        Debug.Log(hit.collider.name); // 클릭된 오브젝트 이름 출력 **

        foreach (GameObject obj in PrdList)
        {
            if (obj.name == hit.collider.name)
            {
                Debug.Log(hit.collider.name + " 오브젝트를 찾았습니다.");
                found = true;
                cnt += 1;
                //.SetActive(true); // 어떻게 하면 좋을까
                GameObject.Find("product").transform.Find(obj.name).gameObject.SetActive(false); // 진열대에서 없애기
                GameObject.Find("cart").transform.Find(obj.name).gameObject.SetActive(true);
                Debug.Log("담은 물건 수: " + cnt);
            }
        }
        if (!found) // 없었다면*** 
            GameFail();

        if (cnt == PrdList.Count)
            GameSuccess();


    }
    void GameSuccess() // 맞는 물품을 모두 골랐을 경우
    {
        Debug.Log("Game Success");
        //GameObject.Find("success").SetActive(true);
        GameObject.Find("Canvas").transform.Find("success").gameObject.SetActive(true);
        GameObject.Find("buttonCanvas").transform.Find("check").gameObject.SetActive(true); //확인 버튼 활성화

        GameObject.Find("left").SetActive(false);
        GameObject.Find("right").SetActive(false);
        GameObject.Find("product").SetActive(false);
        GameObject.Find("timerbar").SetActive(false); // 타이머 비활성화 해버리기
        GameObject.Find("timetext").SetActive(false);
        GameObject.Find("BG").transform.Find("opacity").gameObject.SetActive(true);
    }
    void GameFail() //타이머가 끝났을 경우, 다른 물품을 선택했을 경우 (2가지 경우)
    {
        Debug.Log("다른 물건 선택. fail");
        // 화살표, 물품 비활성화
        GameObject.Find("Canvas").transform.Find("fail").gameObject.SetActive(true);

        GameObject.Find("left").SetActive(false);
        GameObject.Find("right").SetActive(false);
        GameObject.Find("product").SetActive(false);
        GameObject.Find("timerbar").SetActive(false);
        GameObject.Find("timetext").SetActive(false);
        GameObject.Find("buttonCanvas").transform.Find("replay").gameObject.SetActive(true);
        GameObject.Find("BG").transform.Find("opacity").gameObject.SetActive(true);

    }

    void Update() // 이거 맞나?
    {
        MouseClickDown();
    }

}
   

