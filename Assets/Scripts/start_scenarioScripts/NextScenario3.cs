using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextScenario3 : MonoBehaviour
{
    // scene3->scene4
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("click the scene3!!!");
            GameObject.Find("Canvas/scene3").SetActive(false);
            GameObject.Find("Canvas").transform.Find("scene4").gameObject.SetActive(true);
        }
    }
}
