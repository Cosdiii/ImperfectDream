using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GoScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void My_Play_Quit(string sname)
    {
        if (sname == "Quit")
            Application.Quit();

        Destroy(GameObject.Find("FlowerSystem"));
        Destroy(GameObject.Find("DefaultDialogPrefab(Clone)"));

        SceneManager.LoadScene(sname);
    }
}
