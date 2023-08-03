using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectedHClick : MonoBehaviour
{
    // Start is called before the first frame update
    public HomesManager manage;

    private void Start()
    {
        manage = GameObject.Find("HomesManager").GetComponent<HomesManager>();
    
    }
    private void Update()
    {
        if (Input.GetMouseButtonDown(0)) // ���� ���콺 ��ư Ŭ��
        {
            Vector2 clickPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(clickPosition, Vector2.zero);

            if (hit.collider != null)
            {
                // Ŭ���� Sprite�� ���� ó���� ���⿡ �ۼ��մϴ�.
                Debug.Log("Clicked on Sprite: " + hit.collider.gameObject.name+ manage.selectedOption_home);
                if (manage.selectedOption_home == 1)
                    SceneManager.LoadScene(4);
            }
        }
    }
}