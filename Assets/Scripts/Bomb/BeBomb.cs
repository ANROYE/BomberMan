﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeBomb : MonoBehaviour {
    /// <summary>
    ///This class is for box object to set active be false when explored
    /// 
    /// <Author> Wumenghua </Author>
    /// </summary>
    
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Explosion"))
        {
            gameObject.SetActive(false);
        }
    }

}