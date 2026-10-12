using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewPlayerCollision : MonoBehaviour
{
    public GameObject jumpScare;
    public DialogManager dialogManager;

    // Start is called before the first frame update
    void Start()
    {
        jumpScare.SetActive(false);
    }

    void Update()
    {
        // 检测玩家是否按下 "E" 键
        if (Input.GetKeyDown(KeyCode.E))
        {
            // 在这里检测是否碰撞到了桌子，并调用 DialogManager 的方法
            CheckCollisionWithTable();
        }
    }
    void CheckCollisionWithTable()
    {
        Collider2D[] colliders = Physics2D.OverlapCircleAll(transform.position, 1f); // 假设半径为1的圆形区域用来检测碰撞
        foreach (Collider2D collider in colliders)
        {
            if (collider.gameObject.CompareTag("Table"))
            {
                Debug.Log("E key pressed and collided with table.");
                dialogManager.ShowDialogRow(); // 调用 DialogManager 的方法

                // 在这里显示对话框
                dialogManager.Dialog.SetActive(true);
                break; // 只处理第一个碰撞到的桌子，可以根据实际情况调整
            }
        }
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
