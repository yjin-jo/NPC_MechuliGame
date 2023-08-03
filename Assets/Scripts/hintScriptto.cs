using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class hintScriptto : MonoBehaviour
{
    //[SerializeField] private GameObject hint;
    //[SerializeField] private GameObject hint_page;
    // Start is called before the first frame update
    /*void Start()
    {
        
    }

    public void ThirdScene()
    {
        SceneManager.LoadScene("MainScene 2");
    }*/
    void gotoAnotherScene()
    {
        //if (Input.GetMouseButtonDown(0))
        SceneManager.LoadScene(6);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //SceneManager.LoadScene(6);
            //hint_page.SetActive(false);
            //hint.SetActive(true);
            gotoAnotherScene();
        }
        
    }

}
