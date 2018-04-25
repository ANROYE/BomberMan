using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CreatExplore : MonoBehaviour {
    /// <summary>
    ///This class is creat explore when the bomb set active be false
    /// 
    /// <Author> Wumenghua </Author>
    /// </summary>

    public int boomRange = 2;

    public GameObject explore;
    public LayerMask LayerMask;
   
    private float waitToBoom;
    private RaycastHit bombHit;
   
    // Use this for initialization
    void Start () {
        waitToBoom = 2.8f;
        StartCoroutine(Boom(Vector3.forward));
        StartCoroutine(Boom(Vector3.back));
        StartCoroutine(Boom(Vector3.right));
        StartCoroutine(Boom(Vector3.left));
    }


    /// <summary>
    /// This IEnumerator is use to raycast direction
    /// 
    /// </summary>
    /// <param name="direction"></param>
    /// <returns></returns>
    IEnumerator Boom(Vector3 direction)
    {
       
        yield return new WaitForSeconds(waitToBoom);
        Instantiate(explore, transform.position, transform.rotation);


        //十字爆炸
        for (int i = 1;i< boomRange; i++)
        {
            Physics.Raycast(transform.position+new Vector3(0,0.5f,0), direction, out bombHit, i, LayerMask);            
           
            if (!bombHit.collider)
            {
                Instantiate(explore,transform.position + (i*direction), explore.transform.rotation);

            }
            else
            {
                break;
            }

            
        }
        yield return new WaitForSeconds(0.05f);
        Destroy(gameObject);        
    }

    public void OnTriggerEnter(Collider other)
    {
        if (!explore && other.CompareTag("Explosion"))
        { //如果還沒有爆炸，並且這枚炸彈受到爆炸襲擊
            StopAllCoroutines(); //取消已經叫做的爆炸，否則炸彈可能爆炸兩次
            StartCoroutine(Boom(Vector3.forward));
            StartCoroutine(Boom(Vector3.back));
            StartCoroutine(Boom(Vector3.right));
            StartCoroutine(Boom(Vector3.left));//最後爆炸!
        }
    }
}
