using UnityEngine;

namespace Assets.Scripts.Scenes.Eighth
{
    public class Matches : MonoBehaviour
    {
        public Items ItemId;
        public GameObject Sprite;
        private bool _reavealed = false;
        private BoxCollider2D _collider;

        void Start ()
        {
            _collider = GetComponent<BoxCollider2D>();
        }

        private void OnMouseOver()
        {
            if (Input.GetMouseButtonDown(0))
            {
                if (!_reavealed)
                {
                    Debug.Log("Revealed: " + ItemId);
                    _reavealed = true;
                    Sprite.SetActive(true);
                } 
                else if (_reavealed)
                {
                    Equipment.Instance.AddToInventory(ItemId);
                    Sprite.SetActive(false);
                    _collider.enabled = false;
                }
            }
        }
    }
}
