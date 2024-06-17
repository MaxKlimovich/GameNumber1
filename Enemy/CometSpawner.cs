using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class CometSpawner : MonoBehaviour
{
    public GameObject[] stone;
    public Transform[] spawnPoint;
    
    
    private int rand;
    private int randPosition;
    public float startTimeBtwSpawn = 0f;
    private float timeBtwSpawn;
    
    
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            timeBtwSpawn = startTimeBtwSpawn;
            
            if (timeBtwSpawn <= 0)
            {
                rand = Random.Range(0, stone.Length);
                randPosition = Random.Range(0, spawnPoint.Length);
                Instantiate(stone[rand], spawnPoint[randPosition].transform.position, Quaternion.identity);
                timeBtwSpawn = startTimeBtwSpawn;
            }

            else
            {
                timeBtwSpawn = Time.deltaTime; 
            }
        }
    }

    void Update()
    {
        
    }
}
