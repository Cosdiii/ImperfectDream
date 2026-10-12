using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IconE3 : MonoBehaviour
{
    public GameObject iconE;
    public GameObject iconE1;
    public GameObject iconE2;
    public GameObject iconE3;
    public GameObject iconE4;
    public GameObject iconE5;

    public static string MyRoleClosedTo = "";

    private bool isBGM1Switched = false; // 確保只切換一次 BGM


    // Start is called before the first frame update
    void Start()
    {
        iconE.SetActive(false);
        iconE1.SetActive(false);
        iconE2.SetActive(false);
        iconE3.SetActive(false);
        iconE4.SetActive(false);
        iconE5.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("MyRole is going closed to whichObject: " + this.gameObject.name);

        if (this.gameObject.name == "table")
        {
            MyRoleClosedTo = "table";
            if (Cht14_Flower.flowerSystemProcess3 == 1)
            {
                iconE.SetActive(true);
                iconE1.SetActive(true);
            }
        }

        if (this.gameObject.name == "mirror")
        {
            MyRoleClosedTo = "mirror";
            if (Cht14_Flower.flowerSystemProcess3 == 2)
            {
                iconE.SetActive(true);
                iconE2.SetActive(true);
            }
        }

        if (this.gameObject.name == "door")
        {
            MyRoleClosedTo = "door";
            if (Cht14_Flower.flowerSystemProcess3 == 3)
            {
                iconE.SetActive(true);
                iconE3.SetActive(true);
            }
        }
        if (this.gameObject.name == "door")
        {
            MyRoleClosedTo = "door";
            if (Cht14_Flower.flowerSystemProcess3 == 4)
            {
                iconE.SetActive(true);
                iconE4.SetActive(true);
            }
        }
        if (this.gameObject.name == "door")
        {
            MyRoleClosedTo = "door";
            if (Cht14_Flower.flowerSystemProcess3 == 5)
            {
                iconE.SetActive(true);
                iconE5.SetActive(true);
            }
        }

    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        iconE.SetActive(false);
        iconE1.SetActive(false);
        iconE2.SetActive(false);
        iconE3.SetActive(false);
        iconE4.SetActive(false);
        iconE5.SetActive(false);

        FindObjectOfType<BGMManager>().SwitchToBGM1();
        isBGM1Switched = true; // 防止重複切換

    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        Debug.Log("still get stayed"); //然而只有輸出30次, 因此使用以下程式
    }
}
