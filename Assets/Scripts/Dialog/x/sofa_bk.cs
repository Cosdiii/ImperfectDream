using Flower;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sofa_bk : MonoBehaviour
{
    FlowerSystem fs01;
    private GameObject objToSpawn;
    public GameObject iconE;

    // Start is called before the first frame update
    void Start()
    {
        iconE.SetActive(false);
        fs01 = FlowerManager.Instance.CreateFlowerSystem("FlowerSample01", false);

        fs01.RegisterCommand("FixedMyRoleYN", FixedMyRole_PosYN);

        //given a name for FlowerSystem
        fs01.name = "FlowerSystem_sofa";

    }

    private void FixedMyRole_PosYN(List<string> _params)
    {
        CharacterAMove.lockPlayer = !CharacterAMove.lockPlayer;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0)) //space key or mouse's left key
        {
            fs01.Next();
        }
        //E icon is showing
        if (iconE.activeSelf == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                //Debug.Log("you press E key (onces)");
                fs01.SetupDialog("DefaultDialogPrefab");
                fs01.ReadTextFromResource("sofa");
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        iconE.SetActive(true);

    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        iconE.SetActive(false);

    }
}
