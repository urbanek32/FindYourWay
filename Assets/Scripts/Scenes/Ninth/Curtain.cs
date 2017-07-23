using UnityEngine;

namespace Assets.Scripts.Scenes.Ninth
{
    public class Curtain : MonoBehaviour
    {
        public bool IsCorrect = false;
        public Items ItemId;

        private BoxCollider2D _collider;

        void Start ()
        {
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
                    Destroy(gameObject);
                }
            }
        }
    }
}
