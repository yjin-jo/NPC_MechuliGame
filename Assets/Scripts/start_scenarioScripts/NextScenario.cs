using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class NextScenario : MonoBehaviour
{
    // scene1->scene2
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("click the scene1!!!");
            GameObject.Find("Canvas/scene1").SetActive(false);
            GameObject.Find("Canvas").transform.Find("scene2").gameObject.SetActive(true);

        }
    }
}
