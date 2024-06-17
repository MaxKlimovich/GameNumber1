using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = System.Random;

public class EnemySpawnTrigger : MonoBehaviour
{
    public GameObject Enemy;
    public Transform[] EnemySpawnerPosition;
    private int _randomSpawnPosition;
    public float RepeatRate = 3f;
    public int DestroySpawner = 1;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            InvokeRepeating("EnemySpawner", 0.5f, RepeatRate);
            Destroy(gameObject, DestroySpawner);
            gameObject.GetComponent<BoxCollider>().enabled = false;
        }
    }

    // private void EnemySpawner()
    // {
    //     _randomSpawnPosition = Random.Range(0, EnemySpawnerPosition.Length);
    //     Instantiate(Enemy, EnemySpawnerPosition[_randomSpawnPosition].position, Quaternion.identity);
    // }
}
