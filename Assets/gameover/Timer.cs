using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    [SerializeField] GameObject fail;
    [SerializeField] GameObject success;
    [SerializeField] float maxTime = 40f;
    float timeLeft;
    Image timeBar;

    // Start is called before the first frame update
    void Start()
    {
        fail.SetActive(false);
        success.SetActive(false);
        timeBar = GetComponent<Image>();
        timeLeft = maxTime;
    }

    // Update is called once per frame
    void Update()
    {
        if (timeLeft > 0)
        {
            timeLeft -= Time.deltaTime;
            timeBar.fillAmount = timeLeft / maxTime;
        }
        else // Ÿ�̸Ӱ� �� ���� ���
        {
            fail.SetActive(true);
            //Time.timeScale = 0; //��� ���� ������Ʈ, ���� ����
            GameObject.Find("buttonCanvas").transform.Find("replay").gameObject.SetActive(true);
            GameObject.Find("timerbar").SetActive(false);
            GameObject.Find("timetext").SetActive(false);
            GameObject.Find("right").SetActive(false);
            GameObject.Find("left").SetActive(false);
            GameObject.Find("product").SetActive(false);
            GameObject.Find("BG").transform.Find("opacity").gameObject.SetActive(true);
        }
    }
}
