using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kickbomb : MonoBehaviour
{
    /// <summary>
         ///這個方法用於當玩家吃到這個道具，就可以把炸彈踢走
        ///
         /// <Author> Wumenghua </ Author>
         /// </ summary>


    private void OnTriggerEnter(Collider other)//other指的是碰撞點
    {

        if (other.CompareTag("Player"))//玩家與道具碰撞檢測
        {
            other.GetComponent<PlayerController>().kicking = true;//開啟PlayerController裡面的kicking方法
            Destroy(gameObject);   //道具從場景消失  

        }
    }
}
