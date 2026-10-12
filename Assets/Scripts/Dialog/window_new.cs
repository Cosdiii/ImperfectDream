using Flower;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class window_new : MonoBehaviour
{
    FlowerSystem fs08;

    // Start is called before the first frame update
    void Start()
    {
        fs08 = FlowerManager.Instance.CreateFlowerSystem("FlowerSample08", false);

        fs08.RegisterCommand("FixedMyRoleYN", FixedMyRole_PosYN);

        fs08.RegisterCommand("DestroyMy", DestroyMy_Act);

        //given a name for FlowerSystem
        fs08.name = "FlowerSystem_window";

        fs08.SetupDialog("DefaultDialogPrefab_window");

        fs08.ReadTextFromResource("window");

    }

    private void FixedMyRole_PosYN(List<string> _params)
    {
        CharacterAMove.lockPlayer = !CharacterAMove.lockPlayer;
    }
    private void DestroyMy_Act(List<string> _params)
    {
        Destroy(GameObject.Find("FlowerSystem_window"));
        Destroy(GameObject.Find("DefaultDialogPrefab_window(Clone)"));
    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0)) //space key or mouse's left key
        {
            fs08.Next();
        }
    }

}
