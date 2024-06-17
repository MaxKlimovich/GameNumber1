using UnityEngine;

namespace Fight
{
    public class AlibardaDamageScript : MonoBehaviour
    {
        public int damageAmount = 5;

        private void OnTriggerEnter(Collider other)
        {
            if (other.tag == "Player")
            {
                other.GetComponent<PlayerHealthBarScript>().PlayerTakeDamage(damageAmount);
            }
        }
    }
}