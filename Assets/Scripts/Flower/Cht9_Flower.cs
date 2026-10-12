using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Flower;

public class Cht9_Flower : MonoBehaviour
{
    FlowerSystem fs9;

    // Start is called before the first frame update
    void Start()
    {
        fs9 = FlowerManager.Instance.CreateFlowerSystem("FlowerSample9", false);

        fs9.SetupDialog("DefaultDialogPrefab");
        fs9.ReadTextFromResource("quiz4");


        Cht5_Flower.flowerSystemProcess2 = 5;

        //Time.timeScale = 0 代表遊戲時間沒有在流動、Time.timeScale = 1 代表遊戲時間正常流動。

        fs9.RegisterCommand("FixedMyRoleYN", FixedMyRole_PosYN);
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
            fs9.Next();
        }



    }
}
