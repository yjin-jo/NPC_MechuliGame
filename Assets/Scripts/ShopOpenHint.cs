using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ShopOpenHint : MonoBehaviour
{
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("click the envelope!!!");
            // GameObject.Find("Canvas/envelope")

            GameObject.Find("Canvas/envelope").SetActive(false); 
            // hint 종이 활성화
            GameObject.Find("Canvas").transform.Find("hint").gameObject.SetActive(true); 
        
        }
    }
}
