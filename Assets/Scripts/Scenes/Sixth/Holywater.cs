using UnityEngine;

namespace Assets.Scripts.Scenes.Sixth
{
    public class Holywater : MonoBehaviour
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
                if (!Equipment.Instance.HaveInInventory(Items.BLESSING))
                {
                    Popup.Instance.ShowPopup("I'm not feeling holy enough. Maybe I need absolution");
                    return;
                }

                Debug.Log("This one is: " + ItemId);

            }
        }
    }
}
