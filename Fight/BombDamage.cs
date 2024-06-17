using UnityEngine;

namespace Fight
{
    public class BombDamage : MonoBehaviour
    {
        public int damageAmount = 30;

        private void OnTriggerEnter(Collider other)
        {
            if (other.tag == "Player")
            {
                other.GetComponent<PlayerHealthBarScript>().PlayerTakeDamage(damageAmount);
            }
        }
    }
}