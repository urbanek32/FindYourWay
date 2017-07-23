using UnityEngine;

namespace Assets.Scripts.Scenes.Second
{
    public class Campfire : MonoBehaviour
    {
        private BoxCollider2D _collider;
        public Items ItemId;
        public GameObject Fire;
        public AudioSource FireEnd;

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
                    Popup.Instance.ShowPopup(HelperEnums.GetItemTip(ItemTips.CAMPFIRE));
                    return;
                }

                Equipment.Instance.AddToInventory(ItemId);
                Equipment.Instance.RemoveFromInventory(Items.HOLY_WATER);
                Fire.SetActive(false);
                FireEnd.Play();
                _collider.enabled = false;

            }
        }
    }
}
