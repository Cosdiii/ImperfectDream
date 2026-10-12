using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Flower;

public class Cht18_Flower : MonoBehaviour
{
    FlowerSystem fs18;

    // Start is called before the first frame update
    void Start()
    {
        fs18 = FlowerManager.Instance.CreateFlowerSystem("FlowerSample18", false);

        fs18.SetupDialog("DefaultDialogPrefab");
        fs18.ReadTextFromResource("piece");


        Cht14_Flower.flowerSystemProcess3 = 5;

        //Time.timeScale = 0 代表遊戲時間沒有在流動、Time.timeScale = 1 代表遊戲時間正常流動。

        fs18.RegisterCommand("FixedMyRoleYN", FixedMyRole_PosYN);
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
            fs18.Next();
        }

    }
}
