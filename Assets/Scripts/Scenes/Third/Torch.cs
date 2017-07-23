﻿using UnityEngine;

namespace Assets.Scripts.Scenes.Third
{
    public class Torch : MonoBehaviour
    {

        private BoxCollider2D _collider;
        public bool IsIgnited = false;
        public GameObject TorchLight;

        void Start()
        {
            _collider = GetComponent<BoxCollider2D>();
        }

        private void OnMouseOver()
        {
            if (Input.GetMouseButtonDown(0))
            {
                if (!Equipment.Instance.HaveInInventory(Items.MATCHES))
                {
                    Popup.Instance.ShowPopup(HelperEnums.GetItemTip(ItemTips.TORCH));
                    return;
                }

                TorchLight.SetActive(true);
                IsIgnited = true;
                _collider.enabled = false;
            }
        }
    }
}
