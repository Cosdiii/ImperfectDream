using Flower;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class airer_new : MonoBehaviour
{
    FlowerSystem fs06;

    // Start is called before the first frame update
    void Start()
    {
        fs06 = FlowerManager.Instance.CreateFlowerSystem("FlowerSample06", false);

        fs06.RegisterCommand("FixedMyRoleYN", FixedMyRole_PosYN);

        fs06.RegisterCommand("DestroyMy", DestroyMy_Act);

        //given a name for FlowerSystem
        fs06.name = "FlowerSystem_airer";

        fs06.SetupDialog("DefaultDialogPrefab_airer");

        fs06.ReadTextFromResource("airer");

    }

    private void FixedMyRole_PosYN(List<string> _params)
    {
        CharacterAMove.lockPlayer = !CharacterAMove.lockPlayer;
    }
    private void DestroyMy_Act(List<string> _params)
    {
        Destroy(GameObject.Find("FlowerSystem_airer"));
        Destroy(GameObject.Find("DefaultDialogPrefab_airer(Clone)"));
    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0)) //space key or mouse's left key
        {
            fs06.Next();
        }
    }

}
