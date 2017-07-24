using UnityEngine;

namespace Assets.Scripts.Scenes.Sixth
{
    public class Skeleton : MonoBehaviour
    {
        private void OnMouseOver()
        {
            if (Input.GetMouseButtonDown(0))
            {
                Popup.Instance.ShowPopup(HelperEnums.GetItemTip(ItemTips.SKELETON));
            }
        }
    }
}
