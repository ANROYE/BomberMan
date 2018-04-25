using UnityEngine;

public class PlayerController : MonoBehaviour {

    public string PlayerName;
    public GameObject bomb;
    public float speed;
    public bool isDie = false;

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
