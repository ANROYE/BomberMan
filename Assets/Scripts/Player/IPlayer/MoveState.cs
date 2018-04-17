using Move;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveState :IMovement {
    /// <summary>
    /// This class inherit the abstract class named IMovement
    /// Implement four method
    /// 
    /// <Author> Wumenghua </Author>
    /// </summary>
    private float speed = 2.5f;

    private Vector3 walking;
   
    /// <summary>
    /// This is Constructor to initialize
    /// </summary>
    public MoveState()
    {
        walking = Vector3.forward * speed * Time.deltaTime;
    }

    /// <summary>
    /// The following four method is override the script named IMovement 
    /// It control the player to move forward,back,right,and left
    /// 
    /// </summary>
    /// <param name="player">The script named PlayerController will incoming a object(itself)</param>
    public override void _back(GameObject player)
    {
        
        player.transform.rotation = Quaternion.Euler(0, 180, 0);
        player.transform.Translate(walking);
    }

    public override void _forward(GameObject player)
    {
        
        player.transform.rotation = Quaternion.Euler(0, 0, 0);
        player.transform.Translate(walking);
        
    }

    public override void _left(GameObject player)
    {
        player.transform.rotation = Quaternion.Euler(0, -90, 0);
        player.transform.Translate(walking);
    }

    public override void _right(GameObject player)
    {
        player.transform.rotation = Quaternion.Euler(0, 90, 0);
        player.transform.Translate(walking);
    }
}
