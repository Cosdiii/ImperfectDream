using Flower;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TV_new : MonoBehaviour
{
    FlowerSystem fs04;

    // Start is called before the first frame update
    void Start()
    {
        fs04 = FlowerManager.Instance.CreateFlowerSystem("FlowerSample04", false);

        fs04.RegisterCommand("FixedMyRoleYN", FixedMyRole_PosYN);

        fs04.RegisterCommand("DestroyMy", DestroyMy_Act);

        //given a name for FlowerSystem
        fs04.name = "FlowerSystem_TV";

        fs04.SetupDialog("DefaultDialogPrefab_TV");

        fs04.ReadTextFromResource("TV");

    }

    private void FixedMyRole_PosYN(List<string> _params)
    {
        CharacterAMove.lockPlayer = !CharacterAMove.lockPlayer;
    }
    private void DestroyMy_Act(List<string> _params)
    {
        Destroy(GameObject.Find("FlowerSystem_TV"));
        Destroy(GameObject.Find("DefaultDialogPrefab_TV(Clone)"));
    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0)) //space key or mouse's left key
        {
            fs04.Next();
        }
    }

}
