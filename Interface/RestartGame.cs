using UnityEngine;
using UnityEngine.SceneManagement;

namespace Interface
{
    public class RestartGame : MonoBehaviour
    {
        [SerializeField] private GameObject _restartPanel;

        public void ShowRestartPannel()
        {
            _restartPanel.SetActive(true);
        }

        public void restartLevel()
        {
            SceneManager.LoadScene("IceLand");
        }
    }
}