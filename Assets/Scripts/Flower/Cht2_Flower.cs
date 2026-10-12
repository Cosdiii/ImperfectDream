using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Flower;

public class Cht2_Flower : MonoBehaviour
{
    FlowerSystem fs2;


    // Start is called before the first frame update
    void Start()
    {
        fs2 = FlowerManager.Instance.CreateFlowerSystem("FlowerSample2", false);

        fs2.SetupDialog("DefaultDialogPrefab");
        fs2.ReadTextFromResource("table");

        FindObjectOfType<BGMManager>().SwitchToBGM2();

        Cht1_Flower.flowerSystemProcess = 2;

        //Time.timeScale = 0 代表遊戲時間沒有在流動、Time.timeScale = 1 代表遊戲時間正常流動。

        fs2.RegisterCommand("HaveBlackBGY", HaveBlackBG_Y);
        fs2.RegisterCommand("HaveBlackBGN", HaveBlackBG_N);
        fs2.RegisterCommand("FixedMyRoleYN", FixedMyRole_PosYN);
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

        GameObject.Find("Canvas").GetComponent<Canvas>().enabled = true;
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
            fs2.Next();
        }

    }
}
