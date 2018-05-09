using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeBomb : MonoBehaviour {
    /// <summary>
         ///這個方法用於在探索時設置活動的盒子對象為假
        ///
         /// <Author> Wumenghua </ Author>
         /// </ summary>

    
    void Start () {
		
	}
	
	
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)//other指的是碰撞點
    {
        if (other.CompareTag("Box"))//箱子與炸彈碰撞檢測

        {
            //Destroy(other.gameObject);
            other.gameObject.SetActive(false);//關閉箱子
        }
        else if (other.CompareTag("Player"))//玩家與炸彈碰撞檢測
        {
            other.GetComponent<PlayerController>().isDie = true;//執行PlayerController裡面的isDie方法

            other.gameObject.SetActive(false);//關閉此方法

        }
        

       

    }
    
        
    

}
