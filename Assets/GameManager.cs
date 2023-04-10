using System;
using System.Collections;
using System.Collections.Generic;
using JumpFrog;
using UnityEngine;
using UnityEngine.SceneManagement;
using Random = UnityEngine.Random;

public enum State
{
    Start,
    Playing,
    Lose,
}

public class GameManager : Singleton<GameManager>
{
    public GameObject winUI;

    public State currentState = State.Start;

    public void SetState(State state)
    {
        currentState = state;
    }

    public void Restart(bool up)
    {
        if (up)
        {
            DirGameDataManager.Ins.playerData.LevelUP();
        }

        SceneManager.LoadScene("Game");
    }

    void Start()
    {
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);

            if (hit.collider)
            {
                Debug.Log($"{hit.collider.transform.gameObject.name}"); 
            }
        }
    }

    private bool CheckWin()
    {

        return true;
    }

    public void MoveColor(TesterTube tube)
    {
    }

    

    public void Help()
    {
       
    }
}