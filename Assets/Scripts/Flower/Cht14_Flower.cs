using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Flower;
using UnityEngine.SceneManagement;

public class Cht14_Flower : MonoBehaviour
{
    FlowerSystem fs14;

    public GameObject iconE3;

    private GameObject objToSpawn3;

    public AudioClip pressE;
    AudioSource audioSource;

    static public int flowerSystemProcess3 = 0;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1f;

        audioSource = GetComponent<AudioSource>();

        fs14 = FlowerManager.Instance.CreateFlowerSystem("FlowerSample14", false);
        //fs.SetupDialog(); //DefaultDialogPrefab
        fs14.SetupDialog("DefaultDialogPrefab");
        fs14.ReadTextFromResource("dooropen2");

        flowerSystemProcess3 = 1;

        //Time.timeScale = 0 代表遊戲時間沒有在流動、Time.timeScale = 1 代表遊戲時間正常流動。


        fs14.RegisterCommand("FixedMyRoleYN", FixedMyRole_PosYN);
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
            fs14.Next();
        }


        //E icon is showing
        if (iconE3.activeSelf == true)
        {
            if (Input.GetKeyDown(KeyCode.E) && flowerSystemProcess3 == 1 && IconE3.MyRoleClosedTo == "table")
            {
                //Debug.Log("you press E key (onces)");

                audioSource.PlayOneShot(pressE);

                objToSpawn3 = new GameObject("Ch2");

                Destroy(GameObject.Find("FlowerSystem"));
                Destroy(GameObject.Find("DefaultDialogPrefab(Clone)"));

                objToSpawn3.AddComponent<Cht15_Flower>();
            }

            if (Input.GetKeyDown(KeyCode.E) && flowerSystemProcess3 == 2 && IconE3.MyRoleClosedTo == "mirror")
            {
                //Debug.Log("you press E key (onces)");

                audioSource.PlayOneShot(pressE);

                objToSpawn3 = new GameObject("Ch3");

                Destroy(GameObject.Find("FlowerSystem"));
                Destroy(GameObject.Find("DefaultDialogPrefab(Clone)"));

                objToSpawn3.AddComponent<Cht16_Flower>();
            }

            if (Input.GetKeyDown(KeyCode.E) && flowerSystemProcess3 == 3 && IconE3.MyRoleClosedTo == "door")
            {
                //Debug.Log("you press E key (onces)");

                audioSource.PlayOneShot(pressE);

                objToSpawn3 = new GameObject("Ch4");

                Destroy(GameObject.Find("FlowerSystem"));
                Destroy(GameObject.Find("DefaultDialogPrefab(Clone)"));

                objToSpawn3.AddComponent<Cht17_Flower>();
            }

            if (Input.GetKeyDown(KeyCode.E) & flowerSystemProcess3 == 4 && IconE3.MyRoleClosedTo == "door")
            {
                //Debug.Log("you press E key (onces)");

                audioSource.PlayOneShot(pressE);

                objToSpawn3 = new GameObject("Ch5");

                Destroy(GameObject.Find("FlowerSystem"));
                Destroy(GameObject.Find("DefaultDialogPrefab(Clone)"));

                objToSpawn3.AddComponent<Cht18_Flower>();
            }
            if (Input.GetKeyDown(KeyCode.E) && flowerSystemProcess3 == 5 && IconE3.MyRoleClosedTo == "door")
            {
                SceneManager.LoadScene(05);
            }

        }

    }



}
