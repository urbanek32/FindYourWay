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
                if (!Equipment.Instance.HaveInInventory(Items.GLOVES))
                {
                    Popup.Instance.ShowPopup(HelperEnums.GetItemTip(ItemTips.BOXES));
                    return;
                }
                
                if (IsCorrect)
                {
                    _renderer.color = Color.green;
                    _rowAnswer.IsGoodAnswerSelected = true;
                }
            }
        }
    }
}
