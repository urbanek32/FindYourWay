using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts
{
    public class Equipment : MonoBehaviour
    {
        private static Equipment _instance;

        private Dictionary<Items, GameObject> _visualInventory = new Dictionary<Items, GameObject>(); 
        public Dictionary<Items, bool> Inventory = new Dictionary<Items, bool>();
        public static Equipment Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Equipment();
                }

                return _instance;
            }
        }

        public GameObject ItemPrefab;
        public Transform InventoryTransform;
        public CameraController CameraController;

        public Sprite[] Images;

        public bool IsSecretRoomUnloced = false;

        void Awake()
        {
            if (_instance == null)
            {
                _instance = this;
            }
            else if (_instance != this)
            {
                Destroy(gameObject);
            }

            DontDestroyOnLoad(gameObject);
        }

        void Start ()
        {
            
        }

        void Update ()
        {
		
        }

        public void AddToInventory(Items item)
        {
            Debug.Log("Added: " + item);
            Inventory[item] = true;
            var itemObject = Instantiate(ItemPrefab, InventoryTransform);
            _visualInventory[item] = itemObject;
            var desc = itemObject.GetComponent<ItemDescription>();
            desc.Description = HelperEnums.GetItemDescription(item);
            Debug.Log((int)item);
            desc.Image.sprite = Images[(int)item];
        }

        public bool HaveInInventory(Items item)
        {
            return Inventory.ContainsKey(item);
        }

        public void RemoveFromInventory(Items item)
        {
            Debug.Log("Removed: " + item);
            Inventory.Remove(item);
            Destroy(_visualInventory[item]);
        }

        public void UnlockSecretRoom()
        {
            IsSecretRoomUnloced = true;
            CameraController.NumberOfScenesOnLeft++;
            Debug.Log("Secret room unlocked");
        }
    }
}
