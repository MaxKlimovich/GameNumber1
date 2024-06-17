using Skripts;
using UnityEngine;

namespace Enemy.Knight
{
    public class KnightTimeStay : MonoBehaviour
    {
        [Header("Object")] 
        [SerializeField] GameObject Knight;

        private void Start()
        {
            Invoke("Time", 3f);
        }

        void Time()
        {
            int random;
            random = Random.Range(0, 15);
            if (random > 8)
            {
                Knight.GetComponent<AI_KeyKnight>().AI_Enemy = AI_KeyKnight.AI_State.Idle;
                Invoke("Going", 5f);
            }
            else
            {
                Invoke("Time", 3f);
            }
        }

        void Going()
        {
            Knight.GetComponent<AI_KeyKnight>().AI_Enemy = AI_KeyKnight.AI_State.IsPatrolling;
            Invoke("Time", 0f);
        }
    }
}