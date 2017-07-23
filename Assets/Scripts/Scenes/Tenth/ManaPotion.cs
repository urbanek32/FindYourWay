using UnityEngine;

namespace Assets.Scripts.Scenes.Tenth
{
    public class ManaPotion : MonoBehaviour
    {
        public RowAnswer[] Rows;
        public Items ItemId;

        private SpriteRenderer _renderer;
        private BoxCollider2D _collider;
        private bool _given = false;

        void Start ()
        {
            _collider = GetComponent<BoxCollider2D>();
            _renderer = GetComponent<SpriteRenderer>();
        }

        void Update ()
        {
            if (Rows[0].IsGoodAnswerSelected 
                && Rows[1].IsGoodAnswerSelected
                && Rows[2].IsGoodAnswerSelected 
                && Rows[3].IsGoodAnswerSelected 
                && Rows[4].IsGoodAnswerSelected 
                && !_given)
            {
                _renderer.enabled = true;
                _collider.enabled = true;
            }
        }

        private void OnMouseOver()
        {
            if (Input.GetMouseButtonDown(0))
            {
                Equipment.Instance.AddToInventory(ItemId);
                _collider.enabled = false;
                _renderer.enabled = false;
                _given = true;
            }
        }
    }
}
