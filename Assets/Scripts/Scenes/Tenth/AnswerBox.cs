using UnityEngine;

namespace Assets.Scripts.Scenes.Tenth
{
    public class AnswerBox : MonoBehaviour
    {
        public int Answer;
        public bool IsCorrect;
        private SpriteRenderer _renderer;
        private RowAnswer _rowAnswer;

        void Start ()
        {
            _renderer = GetComponent<SpriteRenderer>();
            _rowAnswer = transform.GetComponentInParent<RowAnswer>();
        }

        private void OnMouseOver()
        {
            if (Input.GetMouseButtonDown(0))
            {
                Debug.Log("This one is: " + IsCorrect);
                if (IsCorrect)
                {
                    _renderer.color = Color.green;
                    _rowAnswer.IsGoodAnswerSelected = true;
                }
            }
        }
    }
}
