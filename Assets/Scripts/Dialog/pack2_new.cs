using Flower;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pack2_new : MonoBehaviour
{
    FlowerSystem fs013;

    // Start is called before the first frame update
    void Start()
    {
        fs013 = FlowerManager.Instance.CreateFlowerSystem("FlowerSample013", false);

        fs013.RegisterCommand("FixedMyRoleYN", FixedMyRole_PosYN);

        fs013.RegisterCommand("DestroyMy", DestroyMy_Act);

        //given a name for FlowerSystem
        fs013.name = "FlowerSystem_pack2";

        fs013.SetupDialog("DefaultDialogPrefab_pack2");

        fs013.ReadTextFromResource("pack2");

    }

    private void FixedMyRole_PosYN(List<string> _params)
    {
        CharacterAMove.lockPlayer = !CharacterAMove.lockPlayer;
    }
    private void DestroyMy_Act(List<string> _params)
    {
        Destroy(GameObject.Find("FlowerSystem_pack2"));
        Destroy(GameObject.Find("DefaultDialogPrefab_pack2(Clone)"));
    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0)) //space key or mouse's left key
        {
            fs013.Next();
        }
    }

}
