using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MonsterController : MonoBehaviour
{
    float speed = -0.03f;
    public float monster_hitpoint = 100.0f;
    public float max_hitpoint = 100;

    //　HP表示用スライダー
    public Slider monster_hpSlider;

    //gemeover画面
    public GameObject tauch_wall;

    // Start is called before the first frame update
    void Start()
    {
        tauch_wall = GameObject.Find("DirectorScript");
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        monster_hpSlider.value = monster_hitpoint / max_hitpoint;

        transform.Translate(0,speed, 0);
        if (monster_hitpoint < 0)
        {
            Destroy(gameObject);
        }

        if (transform.position.y < -0.3f)
        {
            tauch_wall.GetComponent<DirectorScript>().gameover_window();
        }

    }
}
