using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Main_MainManager : MonoBehaviour
{
    public int gameIndex = -1;
    public GameObject[] DontDestroy_Objects;
    private static Main_MainManager instance;
    public int stageClear = 0;

    public static Main_MainManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType<Main_MainManager>();
                DontDestroyOnLoad(instance.gameObject);
            }
            return instance;
        }
    }

    // stage 클리어 후 stageClear 값 변경
    public void ClearStage(int stage)
    {
        stageClear = stage;
        Debug.Log(stageClear);
    }

    // Start is called before the first frame update
    void Awake()
    {

        foreach (GameObject obj in DontDestroy_Objects)
        {
            DontDestroyOnLoad(obj);
            Debug.Log(obj.name);
        }

    }

    // Update is called once per frame
    void Update()
    {
    }
}
