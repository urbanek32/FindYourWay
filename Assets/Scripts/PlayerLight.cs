using UnityEngine;

namespace Assets.Scripts
{
    public class PlayerLight : MonoBehaviour
    {
        public Light Light;
        public float SmoothTimeX;
        private Vector2 _velocity;

        void Update ()
        {
            var mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            var posX = Mathf.SmoothDamp(Light.transform.position.x, mousePos.x, ref _velocity.x, SmoothTimeX);
            var posY = Mathf.SmoothDamp(Light.transform.position.y, mousePos.y, ref _velocity.y, SmoothTimeX);

            Light.transform.position = new Vector3(posX, posY, Light.transform.position.z);
        }
    }
}
