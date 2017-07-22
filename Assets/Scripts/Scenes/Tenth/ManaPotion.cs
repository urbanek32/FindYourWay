using UnityEngine;

namespace Assets.Scripts.Scenes.Tenth
{
    public class ManaPotion : MonoBehaviour
    {
        public RowAnswer[] Rows;
        private bool _given = false;

        void Start ()
        {
		    
        }

        void Update ()
        {
            if (Rows[0].IsGoodAnswerSelected && Rows[1].IsGoodAnswerSelected
                && Rows[2].IsGoodAnswerSelected && !_given)
            {
                _given = true;
                Equipment.Instance.AddToInventory(Items.MANA_POTION);
            }
        }
    }
}
