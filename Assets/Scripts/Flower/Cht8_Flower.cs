using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Flower;

public class Cht8_Flower : MonoBehaviour
{
    FlowerSystem fs8;

    // Start is called before the first frame update
    void Start()
    {
        fs8 = FlowerManager.Instance.CreateFlowerSystem("FlowerSample8", false);

        fs8.SetupDialog("DefaultDialogPrefab");
        fs8.ReadTextFromResource("quiz3");


        Cht5_Flower.flowerSystemProcess2 = 4;

        //Time.timeScale = 0 代表遊戲時間沒有在流動、Time.timeScale = 1 代表遊戲時間正常流動。

        fs8.RegisterCommand("FixedMyRoleYN", FixedMyRole_PosYN);
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
            fs8.Next();
        }



    }
}
