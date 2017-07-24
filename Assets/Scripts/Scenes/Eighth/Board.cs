using UnityEngine;

namespace Assets.Scripts.Scenes.Eighth
{
    public class Board : MonoBehaviour
    {
        private void OnMouseOver()
        {
            if (Input.GetMouseButtonDown(0))
            {
                Popup.Instance.ShowPopup(HelperEnums.GetItemTip(ItemTips.BOARD));
            }
        }
    }
}
