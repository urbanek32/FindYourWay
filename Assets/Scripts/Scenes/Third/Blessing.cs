using UnityEngine;

namespace Assets.Scripts.Scenes.Third
{
    public class Blessing : MonoBehaviour
    {
        public Items ItemId;
        private BoxCollider2D _collider;
        public Torch[] Torches;
        public AudioSource AudioSource;

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
                    AudioSource.Play();
                }
                else
                {
                    Popup.Instance.ShowPopup(HelperEnums.GetItemTip(ItemTips.BLESSING));
                    return;
                }
            }
        }

        private void OnMouseExit()
        {

        }
    }
}
