using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpScare : MonoBehaviour
{
    public GameObject jumpScare;

    // Start is called before the first frame update
    void Start()
    {
        jumpScare.SetActive(false);
    }
   


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("650")) // 假設怪物的標籤為 "650"
        {
            // 啟用 JumpScare 物件
            jumpScare.SetActive(true);

            // 開始等待 5 秒的協程
            StartCoroutine(HideJumpScareAfterDelay(5f));
        }

    }




    private IEnumerator HideJumpScareAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay);

        // 隱藏 JumpScare 物件
        jumpScare.SetActive(false);
    }





}
