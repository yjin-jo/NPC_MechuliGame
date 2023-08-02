using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Setting : MonoBehaviour
{
    public GameObject Eggs;
    public GameObject Settings;
    public GameObject Sounds;

    public Button btn1;
    public Button btn2;
    public Button btn3;
    
    public void Egg()
    {
        Debug.Log("egg");
        Eggs.SetActive(true);

        btn1.interactable = false; //��ư ��Ȱ��ȭ
        btn2.interactable = false;
        btn3.interactable = false;
    }

    public void Set()
    {
        Settings.SetActive(true);

        btn1.interactable = false; //��ư ��Ȱ��ȭ
        btn2.interactable = false;
        btn3.interactable = false;
    }

    public void Sound()
    {
        Sounds.SetActive(true);

        btn1.interactable = false; //��ư ��Ȱ��ȭ
        btn2.interactable = false;
        btn3.interactable = false;
    }

    public void Back()
    {
        Eggs.SetActive(false);
        Settings.SetActive(false);
        Sounds.SetActive(false);

        btn1.interactable = true; //��ư Ȱ��ȭ
        btn2.interactable = true;
        btn3.interactable = true;
    }
}
