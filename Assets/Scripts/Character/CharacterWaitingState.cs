using UnityEngine;

public class CharacterWaitingState : BaseState
{
    public override void Enter()
    {
        // Set Animation To Idle
        // Set Count Down
        Debug.Log("Enter Running State");
    }

    public override void Exit()
    {
        // Clean Count Down
    }

    public override void Tick()
    {

    }
}