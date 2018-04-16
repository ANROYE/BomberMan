using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {


    public float speed;

    
    private Animator playerAni;
    private Vector3 walking;


    private void Awake()
    {
        
        playerAni = GetComponent<Animator>();

    }

    private void Start()
    {
        walking = Vector3.forward * speed * Time.deltaTime;
    }

    private void FixedUpdate()
    {
        if (GameManager._instance._GetGameState() == GameManager.State.PLAY)
        {
            Walk();
        }
        else 
        {
            return;
        }
        

    }

    private void Walk()
    {
        
        playerAni.SetBool("Walking", false);
        if (Input.GetKey(KeyCode.W))
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);            
            transform.Translate(walking);
            playerAni.SetBool("Walking",true);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.rotation = Quaternion.Euler(0,180,0);            
            transform.Translate(walking);
            playerAni.SetBool("Walking", true);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.rotation = Quaternion.Euler(0, -90, 0);            
            transform.Translate(walking);
            playerAni.SetBool("Walking", true);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.rotation = Quaternion.Euler(0, 90, 0);            
            transform.Translate(walking);
            playerAni.SetBool("Walking", true);
        }

    }
}
