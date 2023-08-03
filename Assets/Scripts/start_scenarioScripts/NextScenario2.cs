using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextScenario2 : MonoBehaviour
{
    // scene2->scene3
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("click the scene2!!!");
            // GameObject.Find("Canvas/envelope")

            GameObject.Find("Canvas/scene2").SetActive(false);
            // hint 종이 활성화
            GameObject.Find("Canvas").transform.Find("scene3").gameObject.SetActive(true);

        }
    }
}
