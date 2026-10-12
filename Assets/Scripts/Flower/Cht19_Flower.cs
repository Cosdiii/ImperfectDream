using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Flower;
using UnityEngine.SceneManagement;

public class Cht19_Flower : MonoBehaviour
{
    FlowerSystem fs19;

    private GameObject objToSpawn3;

    static public int flowerSystemProcess4 = 0;

    // Start is called before the first frame update
    void Start()
    {
        fs19 = FlowerManager.Instance.CreateFlowerSystem("FlowerSample19", false);

        fs19.SetupDialog("DefaultDialogPrefab");
        fs19.ReadTextFromResource("dooropen3");

        flowerSystemProcess4 = 1;

        //Time.timeScale = 0 代表遊戲時間沒有在流動、Time.timeScale = 1 代表遊戲時間正常流動。

        fs19.RegisterCommand("FixedMyRoleYN", FixedMyRole_PosYN);
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
            fs19.Next();
        }

        if (Input.GetKeyDown(KeyCode.E) && flowerSystemProcess4 == 1)
        {
            //Debug.Log("you press E key (onces)");

            objToSpawn3 = new GameObject("Ch2");
            objToSpawn3.AddComponent<Cht20_Flower>();
        }

        if (Input.GetKeyDown(KeyCode.Escape) && flowerSystemProcess4 == 2)
        {
            SceneManager.LoadScene(00);
        }

    }
}
