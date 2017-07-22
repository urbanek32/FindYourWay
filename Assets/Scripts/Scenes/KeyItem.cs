using UnityEngine;

namespace Assets.Scripts.Scenes
{
    public class KeyItem : MonoBehaviour
    {
        public Items ItemId;
        private BoxCollider2D _collider;

        private void Start ()
        {
            _collider = GetComponent<BoxCollider2D>();
        }

        private void Update ()
        {
		    
        }

        private void OnMouseOver()
        {
            if (Input.GetMouseButtonDown(0))
            {
                Equipment.Instance.AddToInventory(ItemId);
                _collider.enabled = false;
            }
        }

        private void OnMouseExit()
        {

        }
    }
}
