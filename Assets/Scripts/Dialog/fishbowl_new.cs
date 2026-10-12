using Flower;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fishbowl_new : MonoBehaviour
{
    FlowerSystem fs03;

    // Start is called before the first frame update
    void Start()
    {
        fs03 = FlowerManager.Instance.CreateFlowerSystem("FlowerSample03", false);

        fs03.RegisterCommand("FixedMyRoleYN", FixedMyRole_PosYN);

        fs03.RegisterCommand("DestroyMy", DestroyMy_Act);

        //given a name for FlowerSystem
        fs03.name = "FlowerSystem_fishbowl";

        fs03.SetupDialog("DefaultDialogPrefab_fishbowl");

        fs03.ReadTextFromResource("fishbowl");

    }

    private void FixedMyRole_PosYN(List<string> _params)
    {
        CharacterAMove.lockPlayer = !CharacterAMove.lockPlayer;
    }
    private void DestroyMy_Act(List<string> _params)
    {
        Destroy(GameObject.Find("FlowerSystem_fishbowl"));
        Destroy(GameObject.Find("DefaultDialogPrefab_fishbowl(Clone)"));
    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0)) //space key or mouse's left key
        {
            fs03.Next();
        }
    }

}
