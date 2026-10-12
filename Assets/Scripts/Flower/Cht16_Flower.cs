using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Flower;

public class Cht16_Flower : MonoBehaviour
{
    FlowerSystem fs16;

    // Start is called before the first frame update
    void Start()
    {
        fs16 = FlowerManager.Instance.CreateFlowerSystem("FlowerSample16", false);

        fs16.SetupDialog("DefaultDialogPrefab");
        fs16.ReadTextFromResource("mirror");


        Cht14_Flower.flowerSystemProcess3 = 3;

        //Time.timeScale = 0 代表遊戲時間沒有在流動、Time.timeScale = 1 代表遊戲時間正常流動。

        fs16.RegisterCommand("FixedMyRoleYN", FixedMyRole_PosYN);
    }

    private void FixedMyRole_PosYN(List<string> _params)
    {
        CharacterAMove.lockPlayer = !CharacterAMove.lockPlayer;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0)) //space key or mouse's left key
        {
            fs16.Next();
        }



    }
}
