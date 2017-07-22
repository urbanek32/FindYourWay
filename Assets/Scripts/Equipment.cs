using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts
{
    public class Equipment : MonoBehaviour
    {
        private static Equipment _instance;

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
            Inventory[Items.EXIT_KEY] = true;
        }

        void Update ()
        {
		
        }

        public void AddToInventory(Items item)
        {
            Debug.Log("Added: " + item);
            Inventory[item] = true;
            var itemObject = Instantiate(ItemPrefab, InventoryTransform);
            var desc = itemObject.GetComponent<ItemDescription>();
            desc.Description = HelperEnums.GetEnumDescription(item);
        }
    }
}
