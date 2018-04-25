﻿using UnityEngine;

public class Player1 : IMovemen
{

    public void SetAnimator(GameObject player, bool start)
    {
        player.GetComponent<Animator>().SetBool("Walking", start);
    }

    public void SetBomb(GameObject player,GameObject bomb)
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Object.Instantiate(bomb,
            new Vector3(Mathf.RoundToInt(player.transform.position.x), 
            player.transform.position.y, 
            Mathf.RoundToInt(player.transform.position.z)), player.transform.rotation);
        }
    }

   

    public void MoveCalculate(GameObject player, float speed)
    {

        player.transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }

    public void MoveBack(GameObject player, float speed)
    {
        if (Input.GetKey(KeyCode.S))
        {
            player.transform.rotation = Quaternion.Euler(0, 180, 0);
            MoveCalculate(player, speed);
            SetAnimator(player, true);
        }
        
    }

    public void MoveForward(GameObject player, float speed)
    {
        if (Input.GetKey(KeyCode.W))
        {
            player.transform.rotation = Quaternion.Euler(0,0,0);
            MoveCalculate(player, speed);
            SetAnimator(player, true);
        }
        
    }

    public void MoveLeft(GameObject player, float speed)
    {
        if (Input.GetKey(KeyCode.A))
        {
            player.transform.rotation = Quaternion.Euler(0, -90, 0);
            MoveCalculate(player, speed);
            SetAnimator(player, true);
        }
        
    }

    public void MoveRight(GameObject player, float speed)
    {
        if (Input.GetKey(KeyCode.D))
        {
            player.transform.rotation = Quaternion.Euler(0, 90, 0);
            MoveCalculate(player, speed);
            SetAnimator(player, true);
        }
        
    }
}
