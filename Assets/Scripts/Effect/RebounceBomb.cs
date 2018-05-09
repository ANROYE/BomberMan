using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RebounceBomb : MonoBehaviour {

         /// <summary>
         ///這個方法用於當玩家吃到這個道具，就有機會造成踢炸彈之後，反而有機會反彈炸彈
         ///
         /// <Author> Wumenghua </ Author>
         /// </ summary>
         /// 
    public GameObject bomb;

	void Start () {
		
	}
	
	void Update () {
       
	}

    private void OnTriggerEnter(Collider other)//other指的是碰撞點
    {
        if (other.CompareTag("Player"))//玩家與道具碰撞檢測
        {
            bomb.GetComponent<CreatExplore>().canBounce = true;//開啟CreatExplore裡面的canBounce方法

            Destroy(gameObject); //道具從場景消失  
        }
    }
}
