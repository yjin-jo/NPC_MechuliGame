using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;


public class BaneulMovetoEndtalk : MonoBehaviour
{
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("click this Scene!!!");
            SceneManager.LoadScene("BaneulEndTalk1");
        }
    }

}
