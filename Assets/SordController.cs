using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SordController : MonoBehaviour
{
    [SerializeField]
    float wepon_attack_value = 30.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Translate(0, 0.1f, 0);
        if ( (transform.position.x < -2.5f) || (transform.position.x > 2.5f) ||
            (transform.position.y < -0.5) || (transform.position.y > 5.0f) )
        {
            Debug.Log("画面外に出た");
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "monster")
        {
            collision.GetComponent<MonsterController>().monster_hitpoint -= wepon_attack_value;
            Debug.Log("敵に"+ wepon_attack_value  + "の攻撃！");
            Destroy(gameObject);
        }
    }
}
