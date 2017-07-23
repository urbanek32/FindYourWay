using UnityEngine;

namespace Assets.Scripts.Scenes.Second
{
    public class Painting : MonoBehaviour
    {
        private BoxCollider2D _collider;

        void Start()
        {
            _collider = GetComponent<BoxCollider2D>();
        }

        private void OnMouseOver()
        {
            if (Input.GetMouseButtonDown(0))
            {
                Debug.Log("JUMP SCARE");
            }
        }
    }
}
