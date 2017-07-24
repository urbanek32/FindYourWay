using UnityEngine;

namespace Assets.Scripts.Scenes.Second
{
    public class Lamp : MonoBehaviour
    {
        private void OnMouseOver()
        {
            if (Input.GetMouseButtonDown(0))
            {
                Popup.Instance.ShowPopup(HelperEnums.GetItemTip(ItemTips.LAMP));
            }
        }
    }
}
