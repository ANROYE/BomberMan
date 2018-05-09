using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombUp : MonoBehaviour { 
    public GameObject bomb;

    /// <summary>
         ///這個方法用於當玩家吃到這個道具，就可以加強炸彈的威力
        ///
         /// <Author> Wumenghua </ Author>
         /// </ summary>


    void Start () {
		
	}
	
	void Update () {
		
	}
    void OnTriggerEnter(Collider other)//other指的是碰撞點
    {
        
        
        if (other.CompareTag("Player"))//玩家與道具碰撞檢測
        {
                           
            other.gameObject.GetComponent<PlayerController>().bombRange = 6;//使炸彈的威力為6，預設為2
            Destroy(gameObject);   //道具從場景消失  
        }
    }
}
