using UnityEngine;

namespace Assets.Scripts.Scenes.Fiveth
{
    public class Sword : MonoBehaviour
    {
        public Items ItemId;
        public AudioSource AudioItem;

        private void OnMouseOver()
        {
            if (Input.GetMouseButtonDown(0))
            {
                Equipment.Instance.AddToInventory(ItemId);
                AudioItem.Play();
                Destroy(gameObject, 0.8f);
            }
        }
    }
}
