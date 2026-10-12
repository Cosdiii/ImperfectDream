using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Flower;
using UnityEngine.SceneManagement;

public class RightBoxButton : MonoBehaviour
{
    FlowerSystem fs4;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0)) //space key or mouse's left key
        {
            fs4.Next();
        }
    }

    public void OnClick()
    {
        fs4 = FlowerManager.Instance.CreateFlowerSystem("FlowerSample4", false);

        fs4.SetupDialog("DefaultDialogPrefab");
        fs4.ReadTextFromResource("sofa");

        Cht1_Flower.flowerSystemProcess = 3;

        SceneManager.LoadScene(01);
    }

}
