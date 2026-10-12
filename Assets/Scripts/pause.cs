using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pause : MonoBehaviour
{

    public GameObject menu;

    public GameObject hint;

    // Start is called before the first frame update
    void Start()
    {
        menu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Escape)) 
        {
            hint.SetActive(false);
            menu.SetActive(true);
            //®É¶¡¼È°±
            Time.timeScale = 0f;
        }
    }
    public void ResumeMyGame()
    {
        Time.timeScale = 1f;
    }
}
