using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Flower;

public class Cht3_Flower : MonoBehaviour
{
    FlowerSystem fs3;


    // Start is called before the first frame update
    void Start()
    {
        fs3 = FlowerManager.Instance.CreateFlowerSystem("FlowerSample3", false);

        fs3.SetupDialog("DefaultDialogPrefab");
        fs3.ReadTextFromResource("box");

        Cht1_Flower.flowerSystemProcess = 3;

        fs3.SetupButtonGroup();
        fs3.SetupButton("4653", () => {
            // Your code here...
            fs3     .Resume(); // Resume system.
            fs3.RemoveButtonGroup(); // Remove the button group.
            fs3.ReadTextFromResource("letter");

            Cht1_Flower.flowerSystemProcess = 3;

            //Resume my game
            ResumeMyGame2();

            Destroy(GameObject.Find("flower-image-fg8"));
        });
        fs3.SetupButton("7432", () => {
            // Your code here...
            fs3.Resume(); // Resume system.
            fs3.RemoveButtonGroup(); // Remove the button group.

            Destroy(new GameObject("Ch3"));
            Cht1_Flower.flowerSystemProcess = 2;

            //Resume my game
            ResumeMyGame2();

            Destroy(GameObject.Find("flower-image-fg8"));
            Destroy(GameObject.Find("FlowerSystem"));
            Destroy(GameObject.Find("DefaultDialogPrefab(Clone)"));
        });
        fs3.SetupButton("6257", () => {
            // Your code here...
            fs3.Resume(); // Resume system.
            fs3.RemoveButtonGroup(); // Remove the button group.

            Destroy(new GameObject("Ch3"));
            Cht1_Flower.flowerSystemProcess = 2;

            //Resume my game
            ResumeMyGame2();

            Destroy(GameObject.Find("flower-image-fg8"));
            Destroy(GameObject.Find("FlowerSystem"));
            Destroy(GameObject.Find("DefaultDialogPrefab(Clone)"));
        });




        //Time.timeScale = 0 代表遊戲時間沒有在流動、Time.timeScale = 1 代表遊戲時間正常流動。

        fs3.RegisterCommand("FixedMyRoleYN", FixedMyRole_PosYN);

        fs3.RegisterCommand("PauseMyGame", PauseMyGame);
        fs3.RegisterCommand("ResumeMyGame", ResumeMyGame);

    }

    private void FixedMyRole_PosYN(List<string> _params)
    {
        CharacterAMove.lockPlayer = !CharacterAMove.lockPlayer;
    }

    private void PauseMyGame(List<string> _params)
    {
        //時間暫停
        Time.timeScale = 0f;
    }
    private void ResumeMyGame(List<string> _params)
    {
        Time.timeScale = 1f;
    }
    private void ResumeMyGame2()
    {
        Time.timeScale = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0)) //space key or mouse's left key
        {
            fs3 .Next();
        }



    }
}
