using System.Collections.Generic;
using UnityEngine;

public class GameRunningState : BaseState
{
    [SerializeField] GameObject characterPrefab;
    [SerializeField] List<Transform> spawnPoints;
    [SerializeField] int numberOfFighters;
    CharacterGO character;
    public override void Enter()
    {
        character = Instantiate(characterPrefab, spawnPoints[0].position, Quaternion.identity).GetComponent<CharacterGO>();
    }

    public override void Exit()
    {
        throw new System.NotImplementedException();
    }

    public override void Tick()
    {
        Debug.Log("Hurray");
    }
}