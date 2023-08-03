using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ShopReplayButton : MonoBehaviour
{
    //restart 버튼을 누르면
    public void OnMouseDown()
    {
        StartCoroutine(LoadSceneAfterDelay());
    }

    private IEnumerator LoadSceneAfterDelay()
    {
        // 0.5초 동안 대기
        yield return new WaitForSeconds(0.5f);

        //첫 장면 가져오기!!!
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
