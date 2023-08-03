using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ShopStartButton : MonoBehaviour
{
    public void OnMouseDown()
    {
        StartCoroutine(LoadSceneAfterDelay());
    }

    private IEnumerator LoadSceneAfterDelay()
    {
        // 0.5초 동안 대기
        yield return new WaitForSeconds(0.5f);

        //임시 설정.. 추후에 어디로 화면 넘길지 수정
        SceneManager.LoadScene("StartScenario");
    }
}

