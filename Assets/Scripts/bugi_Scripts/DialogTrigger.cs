using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogTrigger : MonoBehaviour
{
    public Dialog info;

    public void Trigger()
    {
        var sys = FindObjectOfType<DialogManager>();
        sys.Begin(info);
    }

   /* public void Awake()
    {
        GameObject.Find("Main_MainManager").GetComponent<Main_MainManager>().gameIndex = 6;
    }*/
}
