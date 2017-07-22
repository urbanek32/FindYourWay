using UnityEngine;

namespace Assets.Scripts.Scenes.First
{
    public class Bookshelf : MonoBehaviour
    {
        public Items ItemId;
        private BoxCollider2D _collider;

        void Start ()
        {
            _collider = GetComponent<BoxCollider2D>();
        }
	
        void Update ()
        {
		
        }

        private void OnMouseOver()
        {
            if (Input.GetMouseButtonDown(0))
            {
                Debug.Log("This one is: " + ItemId);
                Equipment.Instance.AddToInventory(ItemId);
                _collider.enabled = false;

            }
        }
    }
}
