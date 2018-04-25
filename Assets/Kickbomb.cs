﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kickbomb : MonoBehaviour
{
    
    
    void OnTriggerEnter(Collider other)//other指的是碰撞點
    {

        if (other.tag == "Player")//玩家與道具碰撞檢測
        {
            other.transform.GetComponent<PlayerController>().kicking = true;
            Destroy(gameObject);   //道具從場景消失  

        }
    }
}
