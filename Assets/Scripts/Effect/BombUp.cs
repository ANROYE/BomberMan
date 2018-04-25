using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombUp : MonoBehaviour {
    public GameObject bomb;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnTriggerEnter(Collider other)//other指的是碰撞點
    {

        if (other.tag == "Player")//玩家與道具碰撞檢測
        {
            bomb.gameObject.GetComponent<CreatExplore>().boomRange = 6;
            Destroy(gameObject);   //道具從場景消失  

        }
    }
}
