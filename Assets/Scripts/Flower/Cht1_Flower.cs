using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Flower;

public class Cht1_Flower : MonoBehaviour
{
    FlowerSystem fs;

    public GameObject iconE;

    private GameObject objToSpawn;

    public AudioClip pressE;
    AudioSource audioSource;

    static public int flowerSystemProcess = 0;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1f;

        audioSource = GetComponent<AudioSource>();

        fs = FlowerManager.Instance.CreateFlowerSystem("FlowerSample", false);
        //fs.SetupDialog(); //DefaultDialogPrefab
        fs.SetupDialog("DefaultDialogPrefab");
        fs.ReadTextFromResource("tutorial");

        flowerSystemProcess = 1;

        //Time.timeScale = 0 代表遊戲時間沒有在流動、Time.timeScale = 1 代表遊戲時間正常流動。

        fs.RegisterCommand("FixedMyRoleYN", FixedMyRole_PosYN);


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
            fs.Next();
        }


        //E icon is showing
        if (iconE.activeSelf == true)
        {
            
            if (Input.GetKeyDown(KeyCode.E) && flowerSystemProcess == 1 && IconE.MyRoleClosedTo == "table")
            {
                //Debug.Log("you press E key (onces)");

                audioSource.PlayOneShot(pressE);

                Destroy(GameObject.Find("FlowerSystem"));
                Destroy(GameObject.Find("DefaultDialogPrefab(Clone)"));

                objToSpawn = new GameObject("Ch2");
                objToSpawn.AddComponent<Cht2_Flower>();
            }

            if (Input.GetKeyDown(KeyCode.E) && flowerSystemProcess == 2 && IconE.MyRoleClosedTo == "box")
            {
                //Debug.Log("you press E key (onces)");

                audioSource.PlayOneShot(pressE);

                objToSpawn = new GameObject("Ch3");

                Destroy(GameObject.Find("FlowerSystem"));
                Destroy(GameObject.Find("DefaultDialogPrefab(Clone)"));

                if (!objToSpawn.GetComponent<Cht3_Flower>())
                objToSpawn.AddComponent<Cht3_Flower>();
            }

            if (Input.GetKeyDown(KeyCode.E) && flowerSystemProcess == 3 && IconE.MyRoleClosedTo == "door")
            {
                //Debug.Log("you press E key (onces)");

                audioSource.PlayOneShot(pressE);

                objToSpawn = new GameObject("Ch4");

                Destroy(GameObject.Find("FlowerSystem"));
                Destroy(GameObject.Find("DefaultDialogPrefab(Clone)"));

                if (!objToSpawn.GetComponent<Cht4_Flower>())
                    objToSpawn.AddComponent<Cht4_Flower>();
            }
        }

    }



}
