using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterController : MonoBehaviour
{
    public float speed = 0.03f;
    public bool pc_mode = false;
    //　HP表示用スライダー

    public FloatingJoystick variableJoystick;

    //gemeover画面
    public GameObject director_obj;

    void Start()
    {
        director_obj = GameObject.Find("DirectorScript");
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (director_obj.GetComponent<DirectorScript>().pause_flg != true)
        {
            /*キャラクターの移動制御*/
            if (Input.GetKey("up"))
            {
                transform.Translate(0, 1 * speed, 0);
            }
            else if (Input.GetKey("down"))
            {
                transform.Translate(0, -1 * speed, 0);
            }
            else if (Input.GetKey("right"))
            {
                transform.Translate(1 * speed, 0, 0);
            }
            else if (Input.GetKey("left"))
            {
                transform.Translate(-1 * speed, 0, 0);
            }
            else
            {
                transform.Translate(variableJoystick.Horizontal * speed, variableJoystick.Vertical * speed, 0);
            }
            transform.position = new Vector3(Mathf.Clamp(transform.position.x, -2.2f, 2.2f),
            Mathf.Clamp(transform.position.y, 0.0f, 4.6f), 0);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //director_obj.GetComponent<DirectorScript>().damege_hit();
    }

}
