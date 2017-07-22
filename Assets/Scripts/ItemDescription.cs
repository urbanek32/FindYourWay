using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Assets.Scripts
{
    public class ItemDescription : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
    {
        public string Description;

        public GameObject DescriptionBox;
        public Text DecriptionText;
        public Image Image;

        void Start ()
        {
            DescriptionBox = transform.parent.gameObject
                .GetComponent<InventoryBoxHelper>().ItemDescriptionBox;

            DecriptionText = transform.parent.gameObject
                .GetComponent<InventoryBoxHelper>().ItemDescriptionText;

            Image = transform.parent.gameObject
                .GetComponent<Image>();
        }

        public void OnPointerEnter(PointerEventData eventData)
        {
            DescriptionBox.SetActive(true);
            DecriptionText.text = Description;
        }

        public void OnPointerExit(PointerEventData eventData)
        {
            DescriptionBox.SetActive(false);
        }
    }
}
