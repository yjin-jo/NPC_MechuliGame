using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BubbleSpawner : MonoBehaviour
{
    [SerializeField]
    public int objectSpawnCount = 30;
    [SerializeField]
    public GameObject[] prefabArray;
    [SerializeField]
    private Transform[] spawnPointArray;
    public int currentObjectCount = 0;
    private float objectSpawnTime = 0.0f;
    public List<GameObject> bu = new List<GameObject>();

    public void Update()
    {
        //objectSpawnCount 개수만큼만 생성하고 더이상 생성하지 않도록 하기 위해 설정
        if(currentObjectCount + 1 > objectSpawnCount)
        {
            return;
        }
        //원하는 시간마다 오브젝트를 생성하기 위한 시간 변수 연산
        objectSpawnTime += Time.deltaTime;
        
        //0.5초에 한번씩 실행
        if(objectSpawnTime >= 1.0f)
        {
            int prefabIndex = Random.Range(0, prefabArray.Length);
            int spawnIndex = Random.Range(0, spawnPointArray.Length);

            Vector3 position = spawnPointArray[spawnIndex].position;
            GameObject clone = Instantiate(prefabArray[prefabIndex], position, Quaternion.identity);
            bu.Add(clone);

            Vector3 moveDirection = Vector3.up;
            clone.GetComponent<Movement2D>().SetUp(moveDirection);

            currentObjectCount++;
            objectSpawnTime = 0.0f;
        }
    }

    public void DestroyBubble()
    {
        for (int i = 0; i < currentObjectCount; i++)
        {
            bu[i].SetActive(false);
        }
    }

}
