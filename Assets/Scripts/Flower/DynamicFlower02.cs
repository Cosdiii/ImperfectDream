using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Flower;
using UnityEngine.SceneManagement; //scene control

public class DynamicFlower02 : MonoBehaviour
{
    FlowerSystem fsN2;

    bool thisCodeRunFlowerSysCreated = false;

    // Start is called before the first frame update
    void Start()
    {
        //DestroyOnLoad 代表 換場景/進入另一個場景 要不要destroy掉
        //false, 代表 已存在的程式和記憶體的資源 可以 跨 場景
        //true, 代表 已存在的程式和記憶體的資源 把它們destroy掉, 不要 跨 場景
        fsN2 = FlowerManager.Instance.CreateFlowerSystem("FlowerSampleN2", false);

        //fsN.ReadTextFromResource("Dynamic_Flower01_start"); //這句語法, 把這一句放在 Update或者 "放在 碰撞事件" 之中

        //Time.timeScale = 0 代表遊戲時間沒有在流動、Time.timeScale = 1 代表遊戲時間正常流動。
        fsN2.RegisterCommand("lock_player", (List<string> _params) => {
            CharacterAMove.lockPlayer = true;
        });


        fsN2.RegisterCommand("unlock_player", (List<string> _params) => {
            CharacterAMove.lockPlayer = false;
        });


        //through the Flower to open the Scene
        fsN2.RegisterCommand("load_scene", (List<string> _params) => {
            SceneManager.LoadScene(_params[0]);  //scene name: End
        });

    }

    // Update is called once per frame
    void Update()
    {

        if (thisCodeRunFlowerSysCreated && (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))) //space key or mouse's left key
        {
            fsN2.Next();
        }

        //halt to the control and animation for this Player
        if (thisCodeRunFlowerSysCreated)
        {
            GameObject.Find("Chapter1/Player1").GetComponent<Animator>().SetBool("Run", false);
            //disable this for going to the next scene "End"
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("Player came to me");

            if (!thisCodeRunFlowerSysCreated) //此程式碼有沒有執行完成過?
            {
                thisCodeRunFlowerSysCreated = true; //此程式碼已有執行完成過

                //fs.SetupDialog(); //DefaultDialogPrefab
                fsN2.SetupDialog("DefaultDialogPrefab");

                fsN2.ReadTextFromResource("Dynamic_Flower02");
            }
        }
    }
}
