using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Flower;

public class Cht5_Flower : MonoBehaviour
{
    FlowerSystem fs5;

    public GameObject iconE2;

    private GameObject objToSpawn2;

    public AudioClip pressE;
    AudioSource audioSource;

    static public int flowerSystemProcess2 = 0;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1f;

        audioSource = GetComponent<AudioSource>();

        fs5 = FlowerManager.Instance.CreateFlowerSystem("FlowerSample5", false);
        //fs.SetupDialog(); //DefaultDialogPrefab
        fs5.SetupDialog("DefaultDialogPrefab");
        fs5.ReadTextFromResource("dooropen1");

        flowerSystemProcess2 = 1;

        //Time.timeScale = 0 代表遊戲時間沒有在流動、Time.timeScale = 1 代表遊戲時間正常流動。

        fs5.RegisterCommand("FixedMyRoleYN", FixedMyRole_PosYN);
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
            fs5.Next();
        }


        //E icon is showing
        if (iconE2.activeSelf == true)
        {
            if (Input.GetKeyDown(KeyCode.E) && flowerSystemProcess2 == 1 && IconE2.MyRoleClosedTo == "quiz")
            {
                //Debug.Log("you press E key (onces)");

                audioSource.PlayOneShot(pressE);

                Destroy(GameObject.Find("FlowerSystem"));
                Destroy(GameObject.Find("DefaultDialogPrefab(Clone)"));

                objToSpawn2 = new GameObject("Ch2");
                objToSpawn2.AddComponent<Cht6_Flower>();
            }

            if (Input.GetKeyDown(KeyCode.E) && flowerSystemProcess2 == 2 && IconE2.MyRoleClosedTo == "table")
            {
                //Debug.Log("you press E key (onces)");

                audioSource.PlayOneShot(pressE);

                objToSpawn2 = new GameObject("Ch7");

                Destroy(GameObject.Find("FlowerSystem"));
                Destroy(GameObject.Find("DefaultDialogPrefab(Clone)"));

                objToSpawn2.AddComponent<Cht11_Flower>();
            }

            if (Input.GetKeyDown(KeyCode.E) && flowerSystemProcess2 == 3 && IconE2.MyRoleClosedTo == "book")
            {
                //Debug.Log("you press E key (onces)");

                audioSource.PlayOneShot(pressE);

                objToSpawn2 = new GameObject("Ch8");

                Destroy(GameObject.Find("FlowerSystem"));
                Destroy(GameObject.Find("DefaultDialogPrefab(Clone)"));

                objToSpawn2.AddComponent<Cht12_Flower>();
            }

            if (Input.GetKeyDown(KeyCode.E) && flowerSystemProcess2 == 4 && IconE2.MyRoleClosedTo == "door")
            {
                //Debug.Log("you press E key (onces)");

                audioSource.PlayOneShot(pressE);

                objToSpawn2 = new GameObject("Ch9");

                Destroy(GameObject.Find("FlowerSystem"));
                Destroy(GameObject.Find("DefaultDialogPrefab(Clone)"));

                objToSpawn2.AddComponent<Cht13_Flower>();
            }

        }

    }



}
