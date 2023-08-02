using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    public GameManager gameManager;
    [SerializeField]
    public int objectSpawnCount = 30;
    [SerializeField]
    public GameObject[] prefabArray;
    //public GameObject fisha;
    public List<GameObject> fi = new List<GameObject>();
    public GameObject fishContainer;

    void Awake()
    {
        for (int i = 0; i < objectSpawnCount; ++i)
        {
            int index = Random.Range(0, prefabArray.Length);
            float x = Random.Range(-7.5f, 7.5f);
            float y = Random.Range(-4.0f, 3.0f);
            Vector3 position = new Vector3(x, y, 0);
            //Vector3 position = new Vector3(-1.5f + i, 0, 0);

            GameObject fisha = Instantiate(prefabArray[index], position, Quaternion.identity) as GameObject;
            fi.Add(fisha);
        }
    }

    public void DestroyFish()
    {       
         for (int i = 0; i < objectSpawnCount; i++)
            {
                fi[i].SetActive(false);
            }           
    }
   
    //void Update()
    //{
        //if (Input.GetMouseButtonDown(0))
        //{
           // Vector2 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            //RaycastHit2D hit = Physics2D.Raycast(pos, Vector2.zero, 0f);
            //if (hit.collider != null)
            //{
               // GameObject click_obj = hit.transform.gameObject;
                //Debug.Log(click_obj.name);
           // }
       // }
    //}

}
