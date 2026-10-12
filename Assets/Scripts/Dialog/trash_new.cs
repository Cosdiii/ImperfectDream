using Flower;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trash_new : MonoBehaviour
{
    FlowerSystem fs010;

    // Start is called before the first frame update
    void Start()
    {
        fs010 = FlowerManager.Instance.CreateFlowerSystem("FlowerSample010", false);

        fs010.RegisterCommand("FixedMyRoleYN", FixedMyRole_PosYN);

        fs010.RegisterCommand("DestroyMy", DestroyMy_Act);

        //given a name for FlowerSystem
        fs010.name = "FlowerSystem_trash";

        fs010.SetupDialog("DefaultDialogPrefab_trash");

        fs010.ReadTextFromResource("trash");

    }

    private void FixedMyRole_PosYN(List<string> _params)
    {
        CharacterAMove.lockPlayer = !CharacterAMove.lockPlayer;
    }
    private void DestroyMy_Act(List<string> _params)
    {
        Destroy(GameObject.Find("FlowerSystem_trash"));
        Destroy(GameObject.Find("DefaultDialogPrefab_trash(Clone)"));
    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0)) //space key or mouse's left key
        {
            fs010.Next();
        }
    }

}
