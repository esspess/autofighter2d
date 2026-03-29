using UnityEngine;

public class StateMachine : MonoBehaviour
{
    private BaseState CurrentState;

    public BaseState GetCurrentState()
    {
        return CurrentState;
    }
    public void SetCurrentState(BaseState newState)
    {
        if (CurrentState != null)
        {
            CurrentState.Exit();
            CurrentState.enabled = false;
        }
        CurrentState = newState;
        CurrentState.enabled = true;
        CurrentState.Enter();
    }
    void Update()
    {
        if (CurrentState != null)
        {
            CurrentState?.Tick();
        }
    }
}