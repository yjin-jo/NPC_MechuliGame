using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopButtonEvent : MonoBehaviour
{

    GameObject Pduct;
    ShopProductMove productMove;

    // Start is called before the first frame update
    void Start()
    {
        Pduct = GameObject.Find("product"); //product로 바꾸기
        productMove = Pduct.GetComponent<ShopProductMove>();
    }

    // Update is called once per frame
    void Update()
    {
    }
    public void LeftBtnDown()
    {
        productMove.LeftMove = true;
    }
    public void RighttBtnDown()
    {
        productMove.RightMove = true;
    }
    public void LeftBtnUp()
    {
        productMove.LeftMove = false;
    }
    public void RighttBtnUp()
    {
        productMove.RightMove = false;
    }
}
