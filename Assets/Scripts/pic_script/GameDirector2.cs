using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameDirector2 : MonoBehaviour
{
    private float GameTime = 26;
    public Text GameTimeText;

    public GameObject fail;
    public GameObject retry;
    public GameObject temporary;

    void Start()
    {
        fail.gameObject.SetActive(false);
        retry.gameObject.SetActive(false);
        temporary.gameObject.SetActive(false);
    }

    void Update()
    {

        if (GameTime.ToString("F0") == "0")
        {
            temporary.gameObject.SetActive(true);
            fail.gameObject.SetActive(true);
            retry.gameObject.SetActive(true);
            //Debug.Log("게임 종료");
        }
        else
        {
            GameTime -= Time.deltaTime;
            //Debug.Log((int)GameTime);
            GameTimeText.text = GameTime.ToString("F0");
        }
    }
}
