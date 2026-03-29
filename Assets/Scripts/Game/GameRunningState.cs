using System.Collections.Generic;
using UnityEngine;

public class GameRunningState : BaseState
{
    [SerializeField] GameObject characterPrefab;
    [SerializeField] List<Transform> spawnPoints;
    [SerializeField] int numberOfFighters;

    public override void Enter()
    {
        numberOfFighters.Times(i =>
        {
            Instantiate(characterPrefab, spawnPoints[i].position, Quaternion.identity);
        });
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