using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class recv_prop : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider c)//这里的c指的都是撞我的節點，不是自己
    {
        Debug.Log("玩家说：" + c.gameObject.name + c.gameObject.layer);
        if (c.gameObject.layer == 9)//是prop層的節點撞的我
        {
            prop p = c.GetComponent<prop>();//獲得撞我的節點的prop组件
            switch (p.prop_type)//判断道具类型
            {
                case 1:
                    Debug.Log("你捡到了道具！");//不同的道具做不同的處理
                    break;
            }
        }
    }
}