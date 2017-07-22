using UnityEngine;

namespace Assets.Scripts.Scenes.Tenth
{
    public class RowAnswer : MonoBehaviour
    {
        public AnswerBox[] AnswerBoxs;
        public bool IsGoodAnswerSelected = false;

        void Start ()
        {
            int index = Random.Range(0, AnswerBoxs.Length);
            AnswerBoxs[index].IsCorrect = true;
        }
    }
}
