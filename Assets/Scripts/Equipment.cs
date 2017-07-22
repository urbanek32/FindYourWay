using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts
{
    public class Equipment : MonoBehaviour
    {
        public Dictionary<Items, bool> Inventory = new Dictionary<Items, bool>(); 

        void Start ()
        {
            Inventory[Items.EXIT_KEY] = true;
        }

        void Update ()
        {
		
        }
    }
}
