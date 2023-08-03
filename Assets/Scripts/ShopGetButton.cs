using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ShopGetButton : MonoBehaviour
{
    public void OnMouseDown()
    {
        StartCoroutine(LoadSceneAfterDelay());
    }

    private IEnumerator LoadSceneAfterDelay()
    {
        // 0.5초 동안 대기
        yield return new WaitForSeconds(0.5f);

        // 대기 시간이 지난 후 힌트 획득 장면으로 전환
        SceneManager.LoadScene("ShoppingGetHint");
    }
}
