using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Flower;

public class WrongBoxButton : MonoBehaviour
{
    FlowerSystem fs3;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0)) //space key or mouse's left key
        {
            fs3.Next();
        }
    }

    public void OnClick()
    {
        fs3 = FlowerManager.Instance.CreateFlowerSystem("FlowerSample4", false);

        fs3.SetupDialog("DefaultDialogPrefab");
        fs3.ReadTextFromResource("sofa");

        Cht1_Flower.flowerSystemProcess = 2;
    }

}
