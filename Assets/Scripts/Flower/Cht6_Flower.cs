using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Flower;

public class Cht6_Flower : MonoBehaviour
{
    FlowerSystem fs6;

    // Start is called before the first frame update
    void Start()
    {
        fs6 = FlowerManager.Instance.CreateFlowerSystem("FlowerSample6", false);

        fs6.SetupDialog("DefaultDialogPrefab");
        fs6.ReadTextFromResource("quiz1");


        Cht5_Flower.flowerSystemProcess2 = 2;

        //Time.timeScale = 0 代表遊戲時間沒有在流動、Time.timeScale = 1 代表遊戲時間正常流動。

        fs6.RegisterCommand("FixedMyRoleYN", FixedMyRole_PosYN);
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
            fs6.Next();
        }



    }
}
