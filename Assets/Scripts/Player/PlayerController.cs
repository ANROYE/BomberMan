using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Move;

public class PlayerController : MonoBehaviour {
    /// <summary>
    /// This class control the player to movement
    /// 
    /// <Author> Wumenghua </Author>
    /// </summary>

    public String playerName;
    public float speed;

    
    private Animator playerAni;
    private Vector3 walking;


    MoveState _moveState;


    private void Awake()
    {
        _moveState = new MoveState();
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
            if (playerName.Equals("Player1"))
            {
                Player_1_Walk();

            }
            else if (playerName.Equals("Player2"))
            {
                Player_2_Walk();
            }
            
        }
       



    }

    
    /// <summary>
    /// This method is for player1
    /// </summary>
    private void Player_1_Walk()
    {

        playerAni.SetBool("Walking", false);
        if (Input.GetKey(KeyCode.W))
        {
            _moveState._forward(gameObject);
            playerAni.SetBool("Walking",true);
           
        }
        if (Input.GetKey(KeyCode.S))
        {
            _moveState._back(gameObject);
            playerAni.SetBool("Walking", true);
        }
        if (Input.GetKey(KeyCode.A))
        {
            _moveState._left(gameObject);
            playerAni.SetBool("Walking", true);
        }
        if (Input.GetKey(KeyCode.D))
        {
            _moveState._right(gameObject);
            playerAni.SetBool("Walking", true);
        }

    }

    /// <summary>
    /// This method is for player2
    /// </summary>
    private void Player_2_Walk()
    {
        
        playerAni.SetBool("Walking", false);
        if (Input.GetKey(KeyCode.UpArrow))
        {
            _moveState._forward(gameObject);
            playerAni.SetBool("Walking", true);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            _moveState._back(gameObject);
            playerAni.SetBool("Walking", true);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            _moveState._left(gameObject);
            playerAni.SetBool("Walking", true);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            _moveState._right(gameObject);
            playerAni.SetBool("Walking", true);
        }

    }
}
