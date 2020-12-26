using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreasureboxManege : MonoBehaviour
{
    //GameObject director_obj;
    //public GameObject tresuremanege_obj;

    //public int treasurebox_lebel;

    // Start is called before the first frame update
    void Start()
    {
        //director_obj = GameObject.Find("DirectorScript");
    }

    // Update is called once per frame
    /*void Update()
    {
        
    }
    */

    public void treasurebox_create(Vector3 generate_position,GameObject treasurebox)
    {
        GameObject new_box = Instantiate(treasurebox) as GameObject;
        new_box.transform.position = generate_position;
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Destroy(gameObject);
        }
    }
}
