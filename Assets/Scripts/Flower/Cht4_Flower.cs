using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Flower;
using UnityEngine.SceneManagement;

public class Cht4_Flower : MonoBehaviour
{
    FlowerSystem fs4;


    // Start is called before the first frame update
    void Start()
    {
        fs4 = FlowerManager.Instance.CreateFlowerSystem("FlowerSample4", false);

        fs4.SetupDialog("DefaultDialogPrefab");
        fs4.ReadTextFromResource("door1");

        fs4.SetupButtonGroup();
        fs4.SetupButton("0614", () => {
            // Your code here...
            fs4.Resume(); // Resume system.
            fs4.RemoveButtonGroup(); // Remove the button group.

            Destroy(new GameObject("Ch4"));
            Cht1_Flower.flowerSystemProcess = 3;

            //Resume my game
            ResumeMyGame2();

            Destroy(GameObject.Find("FlowerSystem"));
            Destroy(GameObject.Find("DefaultDialogPrefab(Clone)"));
        });
        fs4.SetupButton("3658", () => {
            // Your code here...
            fs4.Resume(); // Resume system.
            fs4.RemoveButtonGroup(); // Remove the button group.

            Destroy(new GameObject("Ch4"));
            Cht1_Flower.flowerSystemProcess = 3;

            //Resume my game
            ResumeMyGame2();

            Destroy(GameObject.Find("FlowerSystem"));
            Destroy(GameObject.Find("DefaultDialogPrefab(Clone)"));
        });
        fs4.SetupButton("0917", () => {
            // Your code here...
            fs4 .Resume(); // Resume system.
            fs4.RemoveButtonGroup(); // Remove the button group.

            //Resume my game
            ResumeMyGame2();

            SceneManager.LoadScene(03);
        });




        //Time.timeScale = 0 代表遊戲時間沒有在流動、Time.timeScale = 1 代表遊戲時間正常流動。

        fs4.RegisterCommand("FixedMyRoleYN", FixedMyRole_PosYN);

        fs4.RegisterCommand("PauseMyGame", PauseMyGame);
        fs4.RegisterCommand("ResumeMyGame", ResumeMyGame);
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
            fs4.Next();
        }



    }
}
