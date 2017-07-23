using UnityEngine;
using UnityEngine.SceneManagement;

namespace Assets.Scripts.Scenes.Eleventh
{
    public class Pentagram : MonoBehaviour
    {
        private BoxCollider2D _collider;

        void Start()
        {
            _collider = GetComponent<BoxCollider2D>();
        }

        private void OnMouseOver()
        {
            if (Input.GetMouseButtonDown(0))
            {
                if (!Equipment.Instance.HaveInInventory(Items.EXIT_SCROLL)
                    || !Equipment.Instance.HaveInInventory(Items.MANA_POTION))
                {
                    Popup.Instance.ShowPopup(HelperEnums.GetItemTip(ItemTips.PENTAGRAM));
                    return;
                }
                
                Debug.Log("THE END");
                _collider.enabled = false;
                SceneManager.LoadScene(2);
            }
        }
    }
}
