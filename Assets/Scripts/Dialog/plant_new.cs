using Flower;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plant_new : MonoBehaviour
{
    FlowerSystem fs09;

    // Start is called before the first frame update
    void Start()
    {
        fs09 = FlowerManager.Instance.CreateFlowerSystem("FlowerSample09", false);

        fs09.RegisterCommand("FixedMyRoleYN", FixedMyRole_PosYN);

        fs09.RegisterCommand("DestroyMy", DestroyMy_Act);

        //given a name for FlowerSystem
        fs09.name = "FlowerSystem_plant";

        fs09.SetupDialog("DefaultDialogPrefab_plant");

        fs09.ReadTextFromResource("plant");

    }

    private void FixedMyRole_PosYN(List<string> _params)
    {
        CharacterAMove.lockPlayer = !CharacterAMove.lockPlayer;
    }
    private void DestroyMy_Act(List<string> _params)
    {
        Destroy(GameObject.Find("FlowerSystem_plant"));
        Destroy(GameObject.Find("DefaultDialogPrefab_plant(Clone)"));
    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0)) //space key or mouse's left key
        {
            fs09.Next();
        }
    }

}
