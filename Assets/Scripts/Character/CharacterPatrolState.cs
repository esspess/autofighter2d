using UnityEngine;

public class CharecterPatrolState : MonoBehaviour
{
    public void Enter()
    {
        Debug.Log("CharecterPatrolState Entered");
    }

    public void Exit()
    {
        Debug.Log("CharecterPatrolState Exited");
    }

    public void UpdateState()
    {
        Debug.Log("CharecterPatrolState UpdateState");
    }
}