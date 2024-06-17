using UnityEngine;

namespace Fight
{
    public class HPRespaun : MonoBehaviour
    {
        public GameObject[] hpBoutle;
        public Transform[] spawnPoint;
    
    
        private int rand;
        private int randPosition;
        public float startTimeBtwSpawn = 0f;
        private float timeBtwSpawn;
       
        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.tag == "Player")
            {
                timeBtwSpawn = startTimeBtwSpawn;
            
                if (timeBtwSpawn <= 0)
                {
                    rand = Random.Range(0, hpBoutle.Length);
                    randPosition = Random.Range(0, spawnPoint.Length);
                    Instantiate(hpBoutle[rand], spawnPoint[randPosition].transform.position, Quaternion.identity);
                    timeBtwSpawn = startTimeBtwSpawn;
                }

                else
                {
                    timeBtwSpawn = Time.deltaTime; 
                }
            }
        }
    }
}