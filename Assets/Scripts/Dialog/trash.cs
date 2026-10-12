using Flower;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trash : MonoBehaviour
{
    private GameObject objToSpawn;
    public GameObject iconE;

    // Start is called before the first frame update
    void Start()
    {
        iconE.SetActive(false);

    }


    // Update is called once per frame
    void Update()
    {
        //E icon is showing
        if (iconE.activeSelf == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                this.gameObject.AddComponent<trash_new>();
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
