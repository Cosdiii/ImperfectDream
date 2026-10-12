using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Flower;

public class Cht11_Flower : MonoBehaviour
{
    FlowerSystem fs11;

    // Start is called before the first frame update
    void Start()
    {
        fs11 = FlowerManager.Instance.CreateFlowerSystem("FlowerSample11", false);

        fs11.SetupDialog("DefaultDialogPrefab");
        fs11.ReadTextFromResource("table2");

        FindObjectOfType<BGMManager>().SwitchToBGM2();

        Cht5_Flower.flowerSystemProcess2 = 3;

        //Time.timeScale = 0 代表遊戲時間沒有在流動、Time.timeScale = 1 代表遊戲時間正常流動。

        fs11.RegisterCommand("HaveBlackBGY", HaveBlackBG_Y);
        fs11.RegisterCommand("HaveBlackBGN", HaveBlackBG_N);
        fs11.RegisterCommand("FixedMyRoleYN", FixedMyRole_PosYN);
    }

    private void FixedMyRole_PosYN(List<string> _params)
    {
        CharacterAMove.lockPlayer = !CharacterAMove.lockPlayer;
    }

    private void HaveBlackBG_Y(List<string> _params)
    {
        GameObject.Find("blackBG").GetComponent<SpriteRenderer>().enabled = true;
    }
    private void HaveBlackBG_N(List<string> _params)
    {
        GameObject.Find("blackBG").GetComponent<SpriteRenderer>().enabled = false;
    }
    private void HaveBlackBGY()
    {
        GameObject.Find("blackBG").GetComponent<SpriteRenderer>().enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0)) //space key or mouse's left key
        {
            fs11.Next();
        }



    }
}
