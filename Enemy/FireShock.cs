using UnityEngine;

namespace Skripts
{
    public class FireShock : MonoBehaviour
    {
        private void OnTriggerEnter(Collider other)
        {
            
            if (other.tag.Equals("Figures"))
            {
                other.gameObject.transform.GetChild(1).gameObject.SetActive(true);
                GetComponent<MeshCollider>().enabled = false;
                gameObject.SetActive(false);
            }
            if (other.tag.Equals("DestroyFigures"))
            {
                other.gameObject.transform.GetChild(1).gameObject.SetActive(false);
            }
            
        }
    }
}