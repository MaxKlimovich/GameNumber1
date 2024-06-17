using System;
using UnityEngine;

namespace Fight
{
    public class StoneDamage : MonoBehaviour
    {
        [SerializeField] public float speed = 0.5f; // speed
        public int damageAmount = 10;

        private void Update()
        {
            transform.Rotate(0, speed * Time.deltaTime, 0, Space.Self); // Rotation object
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.tag == "Player")
            {
                other.GetComponent<PlayerHealthBarScript>().PlayerTakeDamage(damageAmount);
            }
        }
    }
}