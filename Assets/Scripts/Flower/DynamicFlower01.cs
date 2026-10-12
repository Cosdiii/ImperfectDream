using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Flower;

public class DynamicFlower01 : MonoBehaviour
{
    FlowerSystem fsN;

    private int progress = 0;
    private bool pickedUpTheKey = false;
    private bool isGameEnd = false;
    private bool isLocked = true;

    // Start is called before the first frame update
    void Start()
    {
        //DestroyOnLoad 代表 換場景/進入另一個場景 要不要destroy掉
        //false, 代表 已存在的程式和記憶體的資源 可以 跨 場景
        //true, 代表 已存在的程式和記憶體的資源 把它們destroy掉, 不要 跨 場景
        fsN = FlowerManager.Instance.CreateFlowerSystem("FlowerSampleN", false);
        //fs.SetupDialog(); //DefaultDialogPrefab
        fsN.SetupDialog("DefaultDialogPrefab");

        //fsN.ReadTextFromResource("Dynamic_Flower01_start"); //這句語法, 把這一句放在 Update 之中

        //Time.timeScale = 0 代表遊戲時間沒有在流動、Time.timeScale = 1 代表遊戲時間正常流動。
        fsN.RegisterCommand("lock_player", (List<string> _params) => {
            CharacterAMove.lockPlayer = true;
        });


        fsN.RegisterCommand("unlock_player", (List<string> _params) => {
            CharacterAMove.lockPlayer = false;
        });

    }

    // Update is called once per frame
    void Update()
    {
        // Your own logic control.
        if (fsN.isCompleted && isLocked && !isGameEnd)  //fsN.isCompleted, Flower已經準備好 可以進行執行了
        {
            if (progress == 0)
            {
                fsN.ReadTextFromResource("table");
                progress = 1;
                return;
            }
           /* else if (progress == 1)
            {
                // 放在update中, 這個狀態, 去產生按鈕, 會執行多次.
                // 所以, 僅只要去執行一次即可(progress為1時, 執行1次; 下一次時刻時, progress要為2 or 3...), 需要將 progress++, 每次加1
                fsN.SetupButtonGroup(); 
                if (!pickedUpTheKey)
                {
                    fsN.SetupButton("Pickup the key.", () => {
                        pickedUpTheKey = true;
                        fsN.Resume();
                        fsN.RemoveButtonGroup();
                        fsN.ReadTextFromResource("demo_key");
                        isLocked = true;

                        progress = 1;
                        return;
                    });
                }
                fsN.SetupButton("Open the door", () => {
                    if (pickedUpTheKey) //have key
                    {
                        fsN.Resume();
                        fsN.RemoveButtonGroup();
                        fsN.ReadTextFromResource("demo_door");
                        isLocked = false;
                        isGameEnd = true;
                        //go to the over of this question

                        return;
                    }
                    else //no key
                    {
                        fsN.Resume();
                        fsN.RemoveButtonGroup();
                        fsN.ReadTextFromResource("demo_locked_door");
                        isLocked = true;
                        
                        progress = 1;
                        return;
                    }
                });

            }*/

            progress++;

        }


        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0)) //space key or mouse's left key
        {
            fsN.Next();
        }

        if (isLocked == false && isGameEnd == true)
        {
            fsN.ReadTextFromResource("Dynamic_Flower01_over");  
            //remove component this code (DynamicFlower01.cs)
            //Destroy(DynamicFlower01);
            Destroy(this);
        }


        //halt to the control and animation for this Hero
        //GameObject.Find("Chapter1/Player").GetComponent<Animator>().SetBool("Run", false);

    }
}
