using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButton : MonoBehaviour
{
    public void OnMouseDown()
    {
        StartCoroutine(LoadSceneAfterDelay());
    }

    private IEnumerator LoadSceneAfterDelay()
    {
        // 0.5�� ���� ���
        yield return new WaitForSeconds(0.5f);

        //�ӽ� ����.. ���Ŀ� ���� ȭ�� �ѱ��� ����
        SceneManager.LoadScene("Scenario");
    }
}

