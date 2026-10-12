using Flower;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class debuff_new : MonoBehaviour
{
    FlowerSystem fs012;

    // Start is called before the first frame update
    void Start()
    {
        fs012 = FlowerManager.Instance.CreateFlowerSystem("FlowerSample012", false);

        fs012.RegisterCommand("FixedMyRoleYN", FixedMyRole_PosYN);

        fs012.RegisterCommand("DestroyMy", DestroyMy_Act);

        //given a name for FlowerSystem
        fs012.name = "FlowerSystem_debuff";

        fs012.SetupDialog("DefaultDialogPrefab_debuff");

        fs012.ReadTextFromResource("debuff");

    }

    private void FixedMyRole_PosYN(List<string> _params)
    {
        CharacterAMove.lockPlayer = !CharacterAMove.lockPlayer;
    }
    private void DestroyMy_Act(List<string> _params)
    {
        Destroy(GameObject.Find("FlowerSystem_debuff"));
        Destroy(GameObject.Find("DefaultDialogPrefab_debuff(Clone)"));
    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0)) //space key or mouse's left key
        {
            fs012.Next();
        }
    }

}
