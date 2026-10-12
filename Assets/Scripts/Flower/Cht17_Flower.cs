using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Flower;

public class Cht17_Flower : MonoBehaviour
{
    FlowerSystem fs17;

    // Start is called before the first frame update
    void Start()
    {
        fs17 = FlowerManager.Instance.CreateFlowerSystem("FlowerSample17", false);

        fs17.SetupDialog("DefaultDialogPrefab");
        fs17.ReadTextFromResource("door3");


        Cht14_Flower.flowerSystemProcess3 = 4;

        //Time.timeScale = 0 代表遊戲時間沒有在流動、Time.timeScale = 1 代表遊戲時間正常流動。

        fs17.RegisterCommand("FixedMyRoleYN", FixedMyRole_PosYN);
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
            fs17.Next();
        }

    }
}
