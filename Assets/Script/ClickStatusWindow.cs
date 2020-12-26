using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickStatusWindow : MonoBehaviour
{
    public GameObject chara_status; /*実際はWeponGeneratorにステータスが記述されている*/
    //public GameObject enemy_status;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        GetComponent<Text>().text = "攻撃力　：" + chara_status.GetComponent<WeponGenerator>().wepon_power.ToString();
    }
}
