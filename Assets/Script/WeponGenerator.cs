using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeponGenerator : MonoBehaviour
{
    public GameObject weponPrefab;
    GameObject character_object;

    [SerializeField]
    float wepon_create_time = 1.0f;
    float delta = 0;

    GameObject director_obj;

    // Start is called before the first frame update
    void Start()
    {
        director_obj = GameObject.Find("DirectorScript");
    }

    // Update is called once per frame
    void Update()
    {
        /*武器の生成制御*/
        if (director_obj.GetComponent<DirectorScript>().pause_flg != true)
        {
            this.delta += Time.deltaTime;
            if (this.delta > wepon_create_time)
            {
                this.delta = 0;
                create_weapon(/*武器の攻撃力、生成速度、移動速度なんかを同時にセットしたい*/);
            }
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            create_weapon(/*武器の攻撃力、生成速度、移動速度なんかを同時にセットしたい*/);
        }
    }

    public void create_weapon() /*武器の生成速度、移動速度を同時にセットしたい*/
    {
        Debug.Log("武器の生成");

        GameObject new_wepon = Instantiate(weponPrefab) as GameObject;
        new_wepon.transform.position = this.transform.position;
    }
}
