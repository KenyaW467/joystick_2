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
    public GameObject director_obj;

    // Start is called before the first frame update
    void Start()
    {
        director_obj = GameObject.Find("DirectorScript");
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
            Destroy(gameObject);
            director_obj.GetComponent<DirectorScript>().damege_hit();
        }

    }
}
