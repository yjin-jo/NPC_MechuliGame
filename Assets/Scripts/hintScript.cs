using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class hintScript : MonoBehaviour
{
    [SerializeField] private GameObject hint_envelope;
    [SerializeField] private GameObject hint_have_mongmong;
    //테스트실패public HomesDatabase homeDB;

    public void OnClickButton1()
    {
        hint_have_mongmong.SetActive(false);
        hint_envelope.SetActive(true);
        //테스트실패PlayerPrefs.SetInt("UnlockedHome", 2);
    }

    
}