using UnityEngine;

namespace Assets.Scripts.Scenes.Seventh
{
    public class Box : MonoBehaviour
    {
        private BoxCollider2D _collider;
        private SpriteRenderer _renderer;


        public bool IsCorrect = false;
        public Items ItemId;

        void Start()
        {
            _renderer = GetComponent<SpriteRenderer>();
            _collider = GetComponent<BoxCollider2D>();
        }

        private void OnMouseOver()
        {
            if (Input.GetMouseButtonDown(0))
            {
                if (IsCorrect)
                {
                    Equipment.Instance.AddToInventory(ItemId);
                    _collider.enabled = false;
                    _renderer.color = Color.green;
                    return;
                }
            }
        }
    }
}
