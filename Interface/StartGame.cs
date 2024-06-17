using UnityEngine;

namespace Interface
{
    public class StartGame : MonoBehaviour
    {
        [SerializeField] private GameObject _startPanel;
        [SerializeField] private GameObject _startHealthPanel;

        public void ShowStartPannel()
        {
            _startPanel.SetActive(false);
        }
        
        public void ShowHealthPannel()
        {
            _startHealthPanel.SetActive(true);
        }
        
    }
}