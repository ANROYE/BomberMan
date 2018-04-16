using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSetBomb : MonoBehaviour {

    public GameObject Bomb;

	// Use this for initialization
	void Start () {
	    	
	}
	
	// Update is called once per frame
	void Update () {

        //按下空白鍵
        if (Input.GetKeyDown(KeyCode.Space))
        {
            CreatBomb();
        }
        
	}

    //創造炸彈
    void CreatBomb()
    {
        Instantiate(Bomb,
            new Vector3(Mathf.RoundToInt(transform.position.x), transform.position.y, Mathf.RoundToInt(transform.position.z)), transform.rotation);
    }
}
