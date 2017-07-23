using UnityEngine;

namespace Assets.Scripts.Scenes.Fiveth
{
    public class Sword : MonoBehaviour
    {
        public Items ItemId;

        private void OnMouseOver()
        {
            if (Input.GetMouseButtonDown(0))
            {
                Equipment.Instance.AddToInventory(ItemId);
                Destroy(gameObject);
            }
        }
    }
}
