using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Flower;

public class Cht12_Flower : MonoBehaviour
{
    FlowerSystem fs12;

    // Start is called before the first frame update
    void Start()
    {
        fs12 = FlowerManager.Instance.CreateFlowerSystem("FlowerSample12", false);

        fs12.SetupDialog("DefaultDialogPrefab");
        fs12.ReadTextFromResource("book");

        Cht5_Flower.flowerSystemProcess2 = 4;

        //Time.timeScale = 0 代表遊戲時間沒有在流動、Time.timeScale = 1 代表遊戲時間正常流動。

        fs12.RegisterCommand("FixedMyRoleYN", FixedMyRole_PosYN);

        GameObject.Find("Canvas").GetComponent<Canvas>().enabled = true;
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
            fs12.Next();
        }



    }
}
