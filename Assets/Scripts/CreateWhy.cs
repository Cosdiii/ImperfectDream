using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateWhy : MonoBehaviour
{
    public GameObject obj, objcopy;


    // Start is called before the first frame update
    void Start()
    {

    }


    float n;
    // Update is called once per frame
    void Update()
    {
        n = n + Time.deltaTime;


        if (n >= 0.25f)
        {

            int r;
            r = Random.Range(1, 5);

            objcopy = GameObject.Instantiate(obj);



            if (r <= 1)
            {
                objcopy.transform.GetChild(0).gameObject.SetActive(true);
                objcopy.transform.GetChild(1).gameObject.SetActive(false);
                objcopy.transform.GetChild(2).gameObject.SetActive(false);
                objcopy.transform.GetChild(3).gameObject.SetActive(false);

                objcopy.name = "help";

            }
            if (r == 2)
            {
                objcopy.transform.GetChild(0).gameObject.SetActive(false);
                objcopy.transform.GetChild(1).gameObject.SetActive(true);
                objcopy.transform.GetChild(2).gameObject.SetActive(false);
                objcopy.transform.GetChild(3).gameObject.SetActive(false);

                objcopy.name = "help";

            }
            if (r == 3)
            {
                objcopy.transform.GetChild(0).gameObject.SetActive(false);
                objcopy.transform.GetChild(1).gameObject.SetActive(false);
                objcopy.transform.GetChild(2).gameObject.SetActive(true);
                objcopy.transform.GetChild(3).gameObject.SetActive(false);

                objcopy.name = "help";

            }
            if (r == 4)
            {
                objcopy.transform.GetChild(0).gameObject.SetActive(false);
                objcopy.transform.GetChild(1).gameObject.SetActive(false);
                objcopy.transform.GetChild(2).gameObject.SetActive(false);
                objcopy.transform.GetChild(3).gameObject.SetActive(true);

                objcopy.name = "help";

            }


            objcopy.transform.position = new Vector3(Random.Range(-8.3f, 8.3f), 7, 0);
            objcopy.SetActive(true);
            n = 0;
        }
    }
}
