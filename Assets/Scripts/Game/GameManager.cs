using System.Collections.Generic;
using System.Linq;
using UnityEngine;
public class GameManager : MonoBehaviour
{
    [SerializeField] StateMachine gameStateMachine;
    [SerializeField] List<BaseState> baseStates;
    enum GameState
    {
        None = -1,
        Start = 0,
        GameRunning,
        Win
    }
    void Start()
    {
        Debug.Log("Game Manager Started");
        ChangeGameState(GameState.GameRunning);
    }

    void ChangeGameState(GameState newState)
    {
        switch (newState)
        {
            case GameState.None:
                break;
            case GameState.Start:
                Debug.Log("Game Has Started");
                break;
            case GameState.GameRunning:
                gameStateMachine.SetCurrentState(baseStates.OfType<GameRunningState>().First());
                Debug.Log("Game Is Running");
                break;
            case GameState.Win:
                Debug.Log("You Win!");
                break;
        }
    }
}