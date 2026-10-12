using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CharacterAMove : MonoBehaviour
{

    Animator anim;
    Rigidbody2D rig;
    SpriteRenderer sprite;

    public static bool lockPlayer = false;

    // Start is called before the first frame update
    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
        rig = gameObject.GetComponent<Rigidbody2D>();
        sprite = gameObject.GetComponent<SpriteRenderer>();
    }

    bool check;
   
    float x; 
    float y;
    // Update is called once per frame
    void Update()
    {
        check = false;
        if (!lockPlayer)
        {
            if (Input.GetKey(KeyCode.A))
            {
                anim.SetBool("AWalkLeft", true);
                if (gameObject.transform.position.x > -23f)
                {

                    gameObject.transform.Translate(-2 * Time.deltaTime, 0, 0);

                    if (Input.GetKey(KeyCode.LeftControl))
                    {
                        anim.SetBool("AWalkLeftQuick", true);
                        gameObject.transform.Translate(-3 * Time.deltaTime, 0, 0);
                    }
                    else { anim.SetBool("AWalkLeftQuick", false); }
                }
                else
                {
                    gameObject.transform.position = new Vector3(-23f, gameObject.transform.position.y, 0);
                }
            }
            else { anim.SetBool("AWalkLeft", false); }


            if (Input.GetKey(KeyCode.D))
            {
                anim.SetBool("AWalkRight", true);
                if (gameObject.transform.position.x < 23f)
                {
                    gameObject.transform.Translate(2 * Time.deltaTime, 0, 0);
                    if (Input.GetKey(KeyCode.LeftControl))
                    {
                        anim.SetBool("AWalkRightQuick", true);
                        gameObject.transform.Translate(3 * Time.deltaTime, 0, 0);
                    }
                    else { anim.SetBool("AWalkRightQuick", false); }
                }
                else
                {
                    gameObject.transform.position = new Vector3(23f, gameObject.transform.position.y, 0);
                }
            }
            else { anim.SetBool("AWalkRight", false); }


            if (Input.GetKey(KeyCode.S))
            {
                anim.SetBool("AWalkFront", true);
                if (gameObject.transform.position.y > -12f)
                {

                    gameObject.transform.Translate(0, -2 * Time.deltaTime, 0);
                    if (Input.GetKey(KeyCode.LeftControl))
                    {
                        gameObject.transform.Translate(0, -3 * Time.deltaTime, 0);
                        anim.SetBool("AWalkFrontQuick", true);
                    }
                    else
                    { anim.SetBool("AWalkFrontQuick", false); }
                }
                else
                {
                    gameObject.transform.position = new Vector3(gameObject.transform.position.x, -12f, 0);
                }
            }
            else { anim.SetBool("AWalkFront", false); }


            if (Input.GetKey(KeyCode.W))
            {
                anim.SetBool("AWalkBack", true);
                if (gameObject.transform.position.y < 8f)
                {

                    gameObject.transform.Translate(0, 2 * Time.deltaTime, 0);
                    if (Input.GetKey(KeyCode.LeftControl))
                    {
                        gameObject.transform.Translate(0, 3 * Time.deltaTime, 0);
                        anim.SetBool("AWalkBackQuick", true);
                    }
                    else
                    { anim.SetBool("AWalkBackQuick", false); }
                }
                else
                {
                    gameObject.transform.position = new Vector3(gameObject.transform.position.x, 8f, 0);
                }
            }
            else { anim.SetBool("AWalkBack", false); }


        }

    }

}
