using System;
using UnityEngine;

namespace Fight
{
    public class FigureBoom : MonoBehaviour
    {
        private void OnTriggerEnter(Collider other)
        {
            if (other.tag.Equals("Shocks"))
            { 
                GetComponent<MeshCollider>().enabled = false;
                // other.gameObject.SetActive(false);
                // Destroy(gameObject);
                
                
                
            }
        }
    }
}