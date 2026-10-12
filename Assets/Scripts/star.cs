using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class star : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void star_1()
    {
        SceneManager.LoadScene(01);
    }
    public void star_2()
    {
        SceneManager.LoadScene(03);
    }
    public void star_3()
    {
        SceneManager.LoadScene(04);
    }
}
