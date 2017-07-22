using UnityEngine;

namespace Assets.Scripts.Scenes.Second
{
    public class Campfire : MonoBehaviour
    {
        private BoxCollider2D _collider;
        public Items ItemId;

        void Start()
        {
            _collider = GetComponent<BoxCollider2D>();
        }

        private void OnMouseOver()
        {
            if (Input.GetMouseButtonDown(0))
            {
                if (!Equipment.Instance.HaveInInventory(Items.HOLY_WATER))
                {
                    Popup.Instance.ShowPopup("I need something to zgasić fire");
                    return;
                }

                Debug.Log("This one is: " + ItemId);
                
            }
        }
    }
}
