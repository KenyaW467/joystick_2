using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DirectorScript : MonoBehaviour
{
    public GameObject weponPrefab;
    GameObject character_object;
    [SerializeField]
    public bool pause_flg = false;
    [SerializeField]
    float wepon_create_time = 1.0f;
    float delta = 0;
    [SerializeField]
    GameObject gameover_panel;

    // Start is called before the first frame update
    void Start()
    {
        character_object = GameObject.Find("syuzinnkou_1");
        gameover_panel.SetActive(false);
    }


    // Update is called once per frame
    void Update()
    {
        /*武器の生成制御*/
        if (pause_flg != true )
        {
            this.delta += Time.deltaTime;
            if (this.delta > wepon_create_time)
            {
                this.delta = 0;
                create_weapon(/*武器の攻撃力、生成速度、移動速度なんかを同時にセットしたい*/);
            }
        }

        if(Input.GetKeyDown(KeyCode.Space))
        {
            create_weapon(/*武器の攻撃力、生成速度、移動速度なんかを同時にセットしたい*/);
        }
    }
    
    public void create_weapon() /*武器の生成速度、移動速度を同時にセットしたい*/
    {
        Debug.Log("武器の生成");

        GameObject new_wepon = Instantiate(weponPrefab) as GameObject;
        new_wepon.transform.position = character_object.transform.position;
    }

    public void gameover_window()
    {
        //gemeover画面の表示
        Time.timeScale = 0;
        pause_flg = true;

        gameover_panel.SetActive(true);
    }
}
