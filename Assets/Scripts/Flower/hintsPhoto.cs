using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class hintsPhoto : MonoBehaviour
{
    public GameObject HintE;
    
    bool thisCodeRunDone = false;

    private int progress = 0;

    // Start is called before the first frame update
    void Start()
    {
        HintE.SetActive(false);
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player")) // 假設標籤為 "player"
        {
            // 啟用 HintE 物件
            HintE.SetActive(true);
            if (Input.GetKeyDown(KeyCode.E))
            {
                SceneManager.LoadScene(02);

            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player")) // 假設標籤為 "player"
        {
            // 隱藏 HintE 物件
            HintE.SetActive(false);
        }
    }
}
