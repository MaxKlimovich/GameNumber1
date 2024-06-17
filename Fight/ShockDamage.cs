using Unity.VisualScripting;
using UnityEngine;

namespace Fight
{
    public class ShockDamage : MonoBehaviour
    {
        public int damageAmount = 15;

        private void OnTriggerEnter(Collider other)
        {
            if (other.tag == "Player")
            {
                other.GetComponent<PlayerHealthBarScript>().PlayerTakeDamage(damageAmount);
                Destroy(gameObject);
            }
        }
    }
}