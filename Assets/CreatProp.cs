using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatProp : MonoBehaviour {

    public GameObject prop;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnDisable()
    {

        Instantiate(prop,gameObject.transform.position, gameObject.transform.rotation);
    }
}
