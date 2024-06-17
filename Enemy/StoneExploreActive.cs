using UnityEngine;

namespace Skripts
{
    public class StoneExploreActive : MonoBehaviour
    {
        private void OnTriggerEnter(Collider other)
        {
            if (other.tag.Equals("Stone"))
            {
                gameObject.SetActive(false);
            
            }
        
        }
    }
}