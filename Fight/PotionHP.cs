using UnityEngine;

namespace Fight
{
    public class PotionHP : MonoBehaviour
    {
        public int healthAmount = 100;

            private void OnTriggerEnter(Collider other)
            {
                if (other.tag == "Player")
                {
                    other.GetComponent<PlayerHealthBarScript>().PlayerHpUp(healthAmount);
                }
            }
    }
}