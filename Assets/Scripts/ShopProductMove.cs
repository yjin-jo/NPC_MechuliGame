using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopProductMove : MonoBehaviour
{
    Animator animator;
    public bool LeftMove = false;
    public bool RightMove = false;
    Vector3 moveVelocity = Vector3.zero;
    float moveSpeed = 100; // 버튼 누르는 동안 오브젝트 이동 속도

    // Start is called before the first frame update
    void Start()
    {
        animator = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (LeftMove) // true인 경우
        {
            animator.SetBool("Direction", false);
            moveVelocity = new Vector3(-0.10f, 0, 0);
            transform.position += moveVelocity * moveSpeed * Time.deltaTime;
        }
        if (RightMove)
        {
            animator.SetBool("Direction", true);
            moveVelocity = new Vector3(+0.10f, 0, 0);
            transform.position += moveVelocity * moveSpeed * Time.deltaTime;
        }
    }
}
