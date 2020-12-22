using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    public float speed = 0.01f;
    public bool pc_mode = false;

    public FloatingJoystick variableJoystick;

    //gemeover画面
    public GameObject tauch_wall;

    void Start()
    {
        tauch_wall = GameObject.Find("DirectorScript");
    }

    // Update is called once per frame
    void Update()
    {
        if (tauch_wall.GetComponent<DirectorScript>().pause_flg != true)
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
        tauch_wall.GetComponent<DirectorScript>().gameover_window();
    }

}
