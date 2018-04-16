using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

    public Text TimeTxt;
    public int CountTimer;


    public static GameManager _instance;

    public enum State
    {
        DELAY,
        PLAY,
        PAUSE,
        GAMEOVER
    }
    State _state;

    private void Awake()
    {
        _state = State.DELAY;
        if (_instance == null)
        {
            _instance = this;
        }else if(_instance != this){
            Destroy(gameObject);
        }
        

    }

    private void Start()
    {
        SetGameState(_state);

        CountTimer = 3;
        TimeTxt.text = string.Empty;
    }

    public void SetGameState(State state)
    {
        switch (state)
        {
            case State.DELAY:
                _DelayGame();
                break;
            case State.PLAY:
                _PlayimgTheGame();
                break;
            case State.PAUSE:
                _PauseTheGame();
                break;
            case State.GAMEOVER:
                _GameIsOver();
                break;
            
        }

    }

    public State _GetGameState()
    {
        return _state;
    }

    void _DelayGame()
    {
        StartCoroutine(CountTime());
    }

    void _PlayimgTheGame()
    {
        TimeTxt.text = string.Empty;
    }

    void _PauseTheGame()
    {

    }

    void _GameIsOver()
    {

    }




    IEnumerator CountTime()
    {

        
        while (CountTimer>0)
        {
            TimeTxt.text = CountTimer + "";
            CountTimer--;
            if (CountTimer == 0)
            {
                yield return new WaitForSeconds(1f);
                TimeTxt.text ="GO!";
                yield return new WaitForSeconds(1f);
                _state = State.PLAY;
                SetGameState(_state);

            }
            yield return new WaitForSeconds(1f);
        }
    }



}
