using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HowTo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(pos, Vector2.zero, 0f);
            if (hit.collider != null)
            {
                GameObject click_obj = hit.transform.gameObject;
                if (click_obj.name == "Image")
                {
                    Debug.Log(click_obj.name);
                    SceneManager.LoadScene("SampleScene_Mieu"); //게임창으로 이동
                }

            }
        }
    }
}
