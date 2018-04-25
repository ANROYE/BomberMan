using System;
using System.Collections;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public string PlayerName;



    public GameObject bomb;//炸彈
    public float speed;//速度
    public bool isDie = false;//玩家死亡
    public bool acce= false;//加速
    public bool kicking = false;
   
    

    private Animator animator;

    IMovemen movemen;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    // Use this for initialization
    void Start () {
        movemen = PlayerState.Movemen(PlayerName);

    }


    private void Update()
    {
        if (acce) {
            StartCoroutine(InitSpeed());
        }
    }

    

    IEnumerator InitSpeed()
    {
        yield return new WaitForSeconds(5f);
        speed = 2.5f;
        StopCoroutine(InitSpeed());
    }

    private void FixedUpdate()

    {
        animator.SetBool("Walking", false);
        if (GameManager._instance._GetGameState() == GameManager.State.PLAY)
        {

            movemen.MoveForward(gameObject, speed);
            movemen.MoveBack(gameObject, speed);
            movemen.MoveLeft(gameObject, speed);
            movemen.MoveRight(gameObject, speed);
            movemen.SetBomb(gameObject, bomb);

        }
    }

    private void OnDisable()
    {
        GameManager._instance.SetGameState(GameManager.State.GAMEOVER);
    }


    
    
}
