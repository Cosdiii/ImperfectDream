using Flower;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class book2_new : MonoBehaviour
{
    FlowerSystem fs07;

    // Start is called before the first frame update
    void Start()
    {
        fs07 = FlowerManager.Instance.CreateFlowerSystem("FlowerSample07", false);

        fs07.RegisterCommand("FixedMyRoleYN", FixedMyRole_PosYN);

        fs07.RegisterCommand("DestroyMy", DestroyMy_Act);

        //given a name for FlowerSystem
        fs07.name = "FlowerSystem_book2";

        fs07.SetupDialog("DefaultDialogPrefab_book2");

        fs07.ReadTextFromResource("book2");

    }

    private void FixedMyRole_PosYN(List<string> _params)
    {
        CharacterAMove.lockPlayer = !CharacterAMove.lockPlayer;
    }
    private void DestroyMy_Act(List<string> _params)
    {
        Destroy(GameObject.Find("FlowerSystem_book2"));
        Destroy(GameObject.Find("DefaultDialogPrefab_book2(Clone)"));
    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0)) //space key or mouse's left key
        {
            fs07.Next();
        }
    }

}
