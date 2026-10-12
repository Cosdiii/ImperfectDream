using Flower;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bed_new : MonoBehaviour
{
    FlowerSystem fs05;

    // Start is called before the first frame update
    void Start()
    {
        fs05 = FlowerManager.Instance.CreateFlowerSystem("FlowerSample05", false);

        fs05.RegisterCommand("FixedMyRoleYN", FixedMyRole_PosYN);

        fs05.RegisterCommand("DestroyMy", DestroyMy_Act);

        //given a name for FlowerSystem
        fs05.name = "FlowerSystem_bed";

        fs05.SetupDialog("DefaultDialogPrefab_bed");

        fs05.ReadTextFromResource("bed");

    }

    private void FixedMyRole_PosYN(List<string> _params)
    {
        CharacterAMove.lockPlayer = !CharacterAMove.lockPlayer;
    }
    private void DestroyMy_Act(List<string> _params)
    {
        Destroy(GameObject.Find("FlowerSystem_bed"));
        Destroy(GameObject.Find("DefaultDialogPrefab_bed(Clone)"));
    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0)) //space key or mouse's left key
        {
            fs05.Next();
        }
    }

}
