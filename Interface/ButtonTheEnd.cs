using UnityEngine;

namespace Interface
{
    public class ButtonTheEnd : MonoBehaviour
    {
        public void OnPressButtonTheEnd()
        {
            FindObjectOfType<TheEnd>().restartLevel();
        }
    }
}