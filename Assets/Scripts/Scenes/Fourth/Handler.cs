using UnityEngine;

namespace Assets.Scripts.Scenes.Fourth
{
    public class Handler : MonoBehaviour
    {
        public bool IsCorrect;
        private bool _unlocked = false;

        void Start ()
        {
		
        }

        private void OnMouseOver()
        {
            if (Input.GetMouseButtonDown(0))
            {
                if (!Equipment.Instance.HaveInInventory(Items.TASSEL))
                {
                    Popup.Instance.ShowPopup("Looks like this rope is missing something");
                    return;
                }

                if (IsCorrect && !_unlocked)
                {
                    _unlocked = true;
                    Equipment.Instance.RemoveFromInventory(Items.TASSEL);
                    Equipment.Instance.UnlockSecretRoom();
                }
            }
        }
    }
}
