using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Flower;
using UnityEngine.SceneManagement;

public class Cht13_Flower : MonoBehaviour
{
    FlowerSystem fs13;


    // Start is called before the first frame update
    void Start()
    {
        fs13 = FlowerManager.Instance.CreateFlowerSystem("FlowerSample13", false);

        fs13.SetupDialog("DefaultDialogPrefab");
        fs13.ReadTextFromResource("door2");

        fs13.SetupButtonGroup();
        fs13.SetupButton("ICANTDOTHIS", () => {
            // Your code here...
            fs13.Resume(); // Resume system.
            fs13.RemoveButtonGroup(); // Remove the button group.

            Destroy(new GameObject("Ch9"));
            Destroy(new GameObject("FlowerSample13"));
            Cht5_Flower.flowerSystemProcess2 = 4;

            //Resume my game
            ResumeMyGame2();

            Destroy(GameObject.Find("flower-image-fg11"));
            Destroy(GameObject.Find("FlowerSystem"));
            Destroy(GameObject.Find("DefaultDialogPrefab(Clone)"));
        });
        fs13.SetupButton("ILOVEYOU", () => {
            // Your code here...
            fs13.Resume(); // Resume system.
            fs13.RemoveButtonGroup(); // Remove the button group.

            ResumeMyGame2();

            SceneManager.LoadScene(04);
        });
        fs13.SetupButton("IMPERFECT", () => {
            // Your code here...
            fs13.Resume(); // Resume system.
            fs13.RemoveButtonGroup(); // Remove the button group.

            Destroy(new GameObject("Ch9"));
            Destroy(new GameObject("FlowerSample13"));
            Cht5_Flower.flowerSystemProcess2 = 4;

            //Resume my game
            ResumeMyGame2();

            Destroy(GameObject.Find("flower-image-fg11"));
            Destroy(GameObject.Find("FlowerSystem"));
            Destroy(GameObject.Find("DefaultDialogPrefab(Clone)"));
        });




        //Time.timeScale = 0 代表遊戲時間沒有在流動、Time.timeScale = 1 代表遊戲時間正常流動。

        fs13.RegisterCommand("FixedMyRoleYN", FixedMyRole_PosYN);

        fs13.RegisterCommand("PauseMyGame", PauseMyGame);
        fs13.RegisterCommand("ResumeMyGame", ResumeMyGame);
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

    private void FixedMyRole_PosYN(List<string> _params)
    {
        CharacterAMove.lockPlayer = !CharacterAMove.lockPlayer;
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0)) //space key or mouse's left key
        {
            fs13.Next();
        }



    }
}
