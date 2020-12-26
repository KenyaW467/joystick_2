using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterGenerator : MonoBehaviour
{
    public GameObject boss_monsterPrefab;
    public GameObject zako_monsterPrefab;
    
    [SerializeField]
    public float span = 1.0f; /*モンスター出現間隔*/
    [SerializeField]
    public int monster_max = 5; /*モンスターの最大出現数*/
    [SerializeField]
    public int boss_monster_rate = 10; /*bossモンスターの出現率*/

    int monster_num = 0; /*モンスターの数*/
    float delta = 0;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        delta += Time.deltaTime;
        if (delta > span)
        {
            delta = 0;
            monster_num++;
            if ( monster_num % boss_monster_rate == 0 )
            {
                GameObject new_monster = Instantiate(boss_monsterPrefab) as GameObject;
                float x_vector_random = Random.Range(-2f, 2f);
                new_monster.transform.position = new Vector3(x_vector_random, 6, 0);
            }
            else
            {
                GameObject new_monster = Instantiate(zako_monsterPrefab) as GameObject;
                float x_vector_random = Random.Range(-2f, 2f);
                new_monster.transform.position = new Vector3(x_vector_random, 6, 0);
            }
        }

    }
}
