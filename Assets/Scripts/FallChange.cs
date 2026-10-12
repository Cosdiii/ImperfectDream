using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;

public class FallChange : MonoBehaviour
{

    public GameObject obj, objcopy;

    // Start is called before the first frame update
    void Start()
    {

    }
    float y;
    private float n;

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.Translate(0, -10 * Time.deltaTime, 0);

        y = gameObject.transform.position.y;
        if (y <= -6)
        {
            GameObject.Destroy(gameObject);


            int r;
            r = Random.Range(1, 5);

            objcopy = GameObject.Instantiate(obj);

            if (r <= 1)
            {
                objcopy.transform.GetChild(0).gameObject.SetActive(true);
                objcopy.transform.GetChild(1).gameObject.SetActive(false);
                objcopy.transform.GetChild(2).gameObject.SetActive(false);
                objcopy.transform.GetChild(3).gameObject.SetActive(false);

                objcopy.name = "word";

            }
            if (r == 2)
            {
                objcopy.transform.GetChild(0).gameObject.SetActive(false);
                objcopy.transform.GetChild(1).gameObject.SetActive(true);
                objcopy.transform.GetChild(2).gameObject.SetActive(false);
                objcopy.transform.GetChild(3).gameObject.SetActive(false);

                objcopy.name = "word";

            }
            if (r == 3)
            {
                objcopy.transform.GetChild(0).gameObject.SetActive(false);
                objcopy.transform.GetChild(1).gameObject.SetActive(false);
                objcopy.transform.GetChild(2).gameObject.SetActive(true);
                objcopy.transform.GetChild(3).gameObject.SetActive(false);

                objcopy.name = "word";

            }
            if (r == 4)
            {
                objcopy.transform.GetChild(0).gameObject.SetActive(false);
                objcopy.transform.GetChild(1).gameObject.SetActive(false);
                objcopy.transform.GetChild(2).gameObject.SetActive(false);
                objcopy.transform.GetChild(3).gameObject.SetActive(true);

                objcopy.name = "word";

            }

            n = Random.Range(0.2f, 4f);
            objcopy.transform.position = new Vector3(Random.Range(-8.3f, 8.3f), Random.Range(-7f, 7f), 0);
            objcopy.transform.localScale =new Vector3(n, n, 0);
            objcopy.SetActive(true);

        }



    }
    private void OnTriggerEnter2D(Collider2D other)
        {
        if (other.tag == "Player")
        {
            GameObject.Destroy(gameObject);
        }

        }
}
