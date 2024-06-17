using UnityEngine;
using UnityEngine.SceneManagement;

namespace Interface
{
    public class TheEnd : MonoBehaviour
    {
        [SerializeField] private GameObject _theEnd;

        public void ShowTheEnd()
        {
            _theEnd.SetActive(true);
        }

        public void restartLevel()
        {
            SceneManager.LoadScene("IceLand");
        }
    }
}