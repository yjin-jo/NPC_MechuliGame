using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectDestroyer : MonoBehaviour
{
    public GameManager gameManager;
    public ObjectSpawner objectSpawner;
    [SerializeField]
    private GameObject playerObject;

    // Start is called before the first frame update

    private void Awake()
    {
        
    }

}
