using UnityEngine;

namespace Assets.Scripts.Scenes.First
{
    public class Bookshelf : MonoBehaviour
    {
        public Items ItemId;
        private BoxCollider2D _collider;
        public AudioSource Audio;

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
                Equipment.Instance.AddToInventory(ItemId);
                _collider.enabled = false;
                Audio.Play();
            }
        }
    }
}
