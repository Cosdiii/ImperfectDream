using Flower;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pack_new : MonoBehaviour
{
    FlowerSystem fs02;

    // Start is called before the first frame update
    void Start()
    {
        fs02 = FlowerManager.Instance.CreateFlowerSystem("FlowerSample02", false);

        fs02.RegisterCommand("FixedMyRoleYN", FixedMyRole_PosYN);

        fs02.RegisterCommand("DestroyMy", DestroyMy_Act);

        //given a name for FlowerSystem
        fs02.name = "FlowerSystem_pack";

        fs02.SetupDialog("DefaultDialogPrefab_pack");

        fs02.ReadTextFromResource("pack");

    }

    private void FixedMyRole_PosYN(List<string> _params)
    {
        CharacterAMove.lockPlayer = !CharacterAMove.lockPlayer;
    }
    private void DestroyMy_Act(List<string> _params)
    {
        Destroy(GameObject.Find("FlowerSystem_pack"));
        Destroy(GameObject.Find("DefaultDialogPrefab_pack(Clone)"));
    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0)) //space key or mouse's left key
        {
            fs02.Next();
        }
    }

}
