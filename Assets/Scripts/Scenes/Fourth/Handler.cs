using UnityEngine;

namespace Assets.Scripts.Scenes.Fourth
{
    public class Handler : MonoBehaviour
    {
        public bool IsCorrect;
        private bool _unlocked = false;
        private BoxCollider2D _collider;
        public AudioSource AudioUnlockedRoom;

        void Start()
        {
            _collider = GetComponent<BoxCollider2D>();
        }

        private void OnMouseOver()
        {
            if (Equipment.Instance.IsSecretRoomUnloced)
            {
                _collider.enabled = false;
                return;
            }

            if (Input.GetMouseButtonDown(0))
            {
                if (!Equipment.Instance.HaveInInventory(Items.TASSEL))
                {
                    Popup.Instance.ShowPopup(HelperEnums.GetItemTip(ItemTips.ROPE));
                    return;
                }

                if (IsCorrect && !_unlocked)
                {
                    _unlocked = true;
                    Equipment.Instance.RemoveFromInventory(Items.TASSEL);
                    Popup.Instance.ShowPopup(HelperEnums.GetItemTip(ItemTips.SECRET_ROOM_UNLOCKED));
                    Equipment.Instance.UnlockSecretRoom();
                    _collider.enabled = false;
                    AudioUnlockedRoom.Play();
                }
            }
        }
    }
}
