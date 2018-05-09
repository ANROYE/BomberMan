using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedUp : MonoBehaviour
{
    /// <summary>
         ///這個方法用於當玩家吃到這個道具，就會有速度提升效果
         ///
         /// <Author> Wumenghua </ Author>
         /// </ summary>
    /// 


   
    void Start()
    {

    }

   
    void Update()
    {

    }

    void OnTriggerEnter(Collider other)//other指的是碰撞點
    {

        if (other.tag == "Player")//玩家與道具碰撞檢測
        {
            other.gameObject.GetComponent<PlayerController>().acce = true;//啟動PlayerController裡面的acce方法
            other.gameObject.GetComponent<PlayerController>().speed = 10f;//10秒後結束此道具的效果
            Destroy(gameObject);   //道具從場景消失  

        }
    }
    
}