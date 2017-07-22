using UnityEngine;

namespace Assets.Scripts.Scenes.Fourth
{
    public class Handler : MonoBehaviour
    {
        public bool IsCorrect;
        public Items ItemId;
        private bool _given = false;

        void Start ()
        {
		
        }

        private void OnMouseOver()
        {
            if (Input.GetMouseButtonDown(0))
            {
                Debug.Log("This one is: " + IsCorrect);
                if (IsCorrect && !_given)
                {
                    _given = true;
                    Equipment.Instance.AddToInventory(ItemId);
                }
            }
        }
    }
}
