using Flower;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shelf_new : MonoBehaviour
{
    FlowerSystem fs011;

    // Start is called before the first frame update
    void Start()
    {
        fs011 = FlowerManager.Instance.CreateFlowerSystem("FlowerSample011", false);

        fs011.RegisterCommand("FixedMyRoleYN", FixedMyRole_PosYN);

        fs011.RegisterCommand("DestroyMy", DestroyMy_Act);

        //given a name for FlowerSystem
        fs011.name = "FlowerSystem_shelf";

        fs011.SetupDialog("DefaultDialogPrefab_shelf");

        fs011.ReadTextFromResource("shelf");

    }

    private void FixedMyRole_PosYN(List<string> _params)
    {
        CharacterAMove.lockPlayer = !CharacterAMove.lockPlayer;
    }
    private void DestroyMy_Act(List<string> _params)
    {
        Destroy(GameObject.Find("FlowerSystem_shelf"));
        Destroy(GameObject.Find("DefaultDialogPrefab_shelf(Clone)"));
    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0)) //space key or mouse's left key
        {
            fs011.Next();
        }
    }

}
