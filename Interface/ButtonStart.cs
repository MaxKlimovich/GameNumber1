using UnityEngine;

namespace Interface
{
    public class ButtonStart : MonoBehaviour
    {
        public void OnPressButton()
        {
            FindObjectOfType<StartGame>().ShowStartPannel();
        }
    }
}