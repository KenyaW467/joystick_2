using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AutoStatusWindow : MonoBehaviour
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
        GetComponent<Text>().text = "生成速度：" + chara_status.GetComponent<WeponGenerator>().wepon_create_time.ToString("F2") + "/sec"
              + "\n" + "攻撃力　：" + chara_status.GetComponent<WeponGenerator>().wepon_power.ToString();
    }
}
