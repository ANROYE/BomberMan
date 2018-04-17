using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSetBomb : MonoBehaviour {
    /// <summary>
    /// This class is for players to set the bomb in the place
    /// 
    /// <Author> Wumenghua </Author>
    /// </summary>

    public GameObject Bomb;

    private string playerName;


    // Use this for initialization
    void Start () {
        playerName = GetComponent<PlayerController>().playerName;
     

    }
	
	// Update is called once per frame
	void Update () {


        if (GameManager._instance._GetGameState() == GameManager.State.PLAY)
        {
            if (playerName.Equals("Player1"))
            {
                if (Input.GetKeyDown(KeyCode.Space))
                {
                    CreatBomb();
                }
            }
            else if (playerName.Equals("Player2"))
            {
                if (Input.GetKeyDown(KeyCode.Keypad0))
                {
                    CreatBomb();
                }
            }
        }              
        
	}

    /// <summary>
    /// This method is use to creat the bomb
    /// </summary>
    void CreatBomb()
    {
        Instantiate(Bomb,
            new Vector3(Mathf.RoundToInt(transform.position.x), transform.position.y, Mathf.RoundToInt(transform.position.z)), transform.rotation);
    }
}
