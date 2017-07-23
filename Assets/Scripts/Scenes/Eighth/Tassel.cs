using UnityEngine;

namespace Assets.Scripts.Scenes.Eighth
{
    public class Tassel : MonoBehaviour
    {
        public Items ItemId;
        public GameObject Sprite;
        private bool _reavealed = false;
        private BoxCollider2D _collider;
        public AudioSource AudioDroppedItem;
        public AudioSource AudioPickedUp;

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
                    _reavealed = true;
                    Sprite.SetActive(true);
                    AudioDroppedItem.Play();
                } 
                else if (_reavealed)
                {
                    Equipment.Instance.AddToInventory(ItemId);
                    Sprite.SetActive(false);
                    _collider.enabled = false;
                    AudioPickedUp.Play();
                }
            }
        }
    }
}
