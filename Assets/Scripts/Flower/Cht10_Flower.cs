using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Flower;

public class Cht10_Flower : MonoBehaviour
{
    FlowerSystem fs10;

    // Start is called before the first frame update
    void Start()
    {
        fs10 = FlowerManager.Instance.CreateFlowerSystem("FlowerSample10", false);

        fs10.SetupDialog("DefaultDialogPrefab");
        fs10.ReadTextFromResource("quiz5");


        Cht5_Flower.flowerSystemProcess2 = 6;

        //Time.timeScale = 0 代表遊戲時間沒有在流動、Time.timeScale = 1 代表遊戲時間正常流動。

        fs10.RegisterCommand("FixedMyRoleYN", FixedMyRole_PosYN);
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
            fs10.Next();
        }



    }
}
