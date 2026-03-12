using System;
using System.Collections.Generic;
using UnityEngine;


public static class IntExtension
{
    public static void Times(this int self, Action<int> action)
    {
        for (int i = 0; i < self; ++i)
        {
            action(i);
        }
    }
}
public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject characterPrefab;
    [SerializeField] List<Transform> spawnPoints;
    [SerializeField] int numberOfFighters;
    void Start()
    {
        // Start the game by spawning some fighters in the arena
        numberOfFighters.Times(i =>
        {
            Instantiate(characterPrefab, spawnPoints[i].position, Quaternion.identity);
        });
    }
}