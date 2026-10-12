using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Flower;
using UnityEngine.SceneManagement;

public class Cht20_Flower : MonoBehaviour
{
    FlowerSystem fs20;

    public int anyTextHaveDone = 0;

    // Start is called before the first frame update
    void Start()
    {
        fs20 = FlowerManager.Instance.CreateFlowerSystem("FlowerSample20", false);

        fs20.SetupDialog("DefaultDialogPrefab");
        fs20.ReadTextFromResource("mib");

        Cht19_Flower.flowerSystemProcess4 = 2;

        //Time.timeScale = 0 代表遊戲時間沒有在流動、Time.timeScale = 1 代表遊戲時間正常流動。

        fs20.RegisterCommand("AnyTextHaveDone_yes", AnyTextHaveDone_yes);

        fs20.RegisterCommand("PauseMyGame", PauseMyGame);
        fs20.RegisterCommand("ResumeMyGame", ResumeMyGame);
    }


    private void AnyTextHaveDone_yes(List<string> _params)
    {
        anyTextHaveDone = 1;
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
            fs20.Next();
        }

        if (anyTextHaveDone==1)
        {
            anyTextHaveDone++;

            fs20.SetupButtonGroup();
            fs20.SetupButton("是", () => {
                // Your code here...
                fs20.Resume(); // Resume system.
                fs20.RemoveButtonGroup(); // Remove the button group.

                ResumeMyGame2();

                fs20.ReadTextFromResource("end1");
            });
            fs20.SetupButton("否", () => {
                // Your code here...
                fs20.Resume(); // Resume system.
                fs20.RemoveButtonGroup(); // Remove the button group.

                ResumeMyGame2();

                fs20.ReadTextFromResource("end2");
            });
        }

    }
}
