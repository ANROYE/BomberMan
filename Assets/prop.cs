using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class prop : MonoBehaviour
{

    public int prop_type; // 道具的類型,不同的道具可以设置不同的類型
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
        Debug.Log("道具说：" + c.gameObject.name + c.gameObject.layer);
        if (c.gameObject.layer == 8)// 是player層的節點撞的我
        {
            GameObject.Destroy(this.gameObject);
        }
    }
}