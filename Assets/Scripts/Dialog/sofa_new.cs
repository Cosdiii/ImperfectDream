using Flower;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sofa_new : MonoBehaviour
{
    FlowerSystem fs01;

    // Start is called before the first frame update
    void Start()
    {
        fs01 = FlowerManager.Instance.CreateFlowerSystem("FlowerSample01", false);

        fs01.RegisterCommand("FixedMyRoleYN", FixedMyRole_PosYN);

        fs01.RegisterCommand("DestroyMy", DestroyMy_Act);

        //given a name for FlowerSystem
        fs01.name = "FlowerSystem_sofa";

        fs01.SetupDialog("DefaultDialogPrefab_sofa");

        fs01.ReadTextFromResource("sofa");

    }

    private void FixedMyRole_PosYN(List<string> _params)
    {
        CharacterAMove.lockPlayer = !CharacterAMove.lockPlayer;
    }
    private void DestroyMy_Act(List<string> _params)
    {
        Destroy(GameObject.Find("FlowerSystem_sofa"));
        Destroy(GameObject.Find("DefaultDialogPrefab_sofa(Clone)"));
    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0)) //space key or mouse's left key
        {
            fs01.Next();
        }
    }

}
