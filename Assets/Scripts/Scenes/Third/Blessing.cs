using UnityEngine;

namespace Assets.Scripts.Scenes.Third
{
    public class Blessing : MonoBehaviour
    {
        public Items ItemId;
        private BoxCollider2D _collider;
        public Torch[] Torches;

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
                if (Torches[0].IsIgnited && Torches[1].IsIgnited)
                {
                    Equipment.Instance.AddToInventory(ItemId);
                    _collider.enabled = false;
                }
                else
                {
                    Popup.Instance.ShowPopup("Goddes can give me abosolution only within god rays");
                    return;
                }
            }
        }

        private void OnMouseExit()
        {

        }
    }
}
