using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DirectorScript : MonoBehaviour
{
    [SerializeField]
    public bool pause_flg = false;
    [SerializeField]
    GameObject gameover_panel;
    [SerializeField]
    int wall_hitpoint = 10;
    public Slider wall_hpSlider;

    public GameObject bgmobj;

    public float experience_point = 0;

    // Start is called before the first frame update
    void Start()
    {
        gameover_panel.SetActive(false);
    }

    void gameover_window()
    {
        //gemeover画面の表示
        Time.timeScale = 0;
        pause_flg = true;
        bgmobj.GetComponent<AudioSource>().Stop();
        gameover_panel.SetActive(true);
    }

    public void damege_hit()
    {
        //gemeover画面の表示
        wall_hitpoint--;
        wall_hpSlider.value = wall_hitpoint;
        GetComponent<AudioSource>().Play();
        if (wall_hitpoint <= 0)
        {
            gameover_window();
        }
    }
    public void get_exp(int exp)
    {
        experience_point += exp;
    }
}
