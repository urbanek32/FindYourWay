using UnityEngine;

namespace Assets.Scripts.Scenes.Ninth
{
    public class Curtain : MonoBehaviour
    {
        public bool IsCorrect = false;
        public Items ItemId;
        public AudioSource AudioItem;

        private BoxCollider2D _collider;

        void Start ()
        {
            _collider = GetComponent<BoxCollider2D>();
        }

        private void OnMouseOver()
        {
            if (Input.GetMouseButtonDown(0))
            {
                if (!Equipment.Instance.HaveInInventory(Items.SWORD))
                {
                    Popup.Instance.ShowPopup(HelperEnums.GetItemTip(ItemTips.CURTAIN));
                    return;
                }

                if (IsCorrect)
                {
                    Equipment.Instance.AddToInventory(ItemId);
                    Equipment.Instance.RemoveFromInventory(Items.SWORD);
                    _collider.enabled = false;
                    AudioItem.Play();
                    Destroy(gameObject, 0.8f);
                }
            }
        }
    }
}
