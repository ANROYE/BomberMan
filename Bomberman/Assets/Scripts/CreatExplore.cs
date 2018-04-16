using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CreatExplore : MonoBehaviour {

    public GameObject explore;

    private float waitToBoom;
    
   


    private void Awake()
    {
        
    }
    // Use this for initialization
    void Start () {
        waitToBoom = 2.8f;
        StartCoroutine(Boom());
    }
	
	// Update is called once per frame
	void Update () {
        
    }

    IEnumerator Boom()
    {
        yield return new WaitForSeconds(waitToBoom);        
        Instantiate(explore,transform.position, transform.rotation);
        Destroy(gameObject);
        
        

    }
}
