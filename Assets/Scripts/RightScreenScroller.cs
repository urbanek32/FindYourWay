using UnityEngine;

namespace Assets.Scripts
{
    public class RightScreenScroller : MonoBehaviour
    {
        public CameraController CameraController;
        public SpriteRenderer Renderer;
        public BoxCollider2D Collider;

        void Update()
        {
            if (CameraController.CurrentScene == 5)
            {
                Renderer.enabled = false;
                Collider.enabled = false;
            }
            else
            {
                Collider.enabled = true;
                Renderer.enabled = true;
            }
        }

        void OnMouseOver()
        {
            if (Input.GetMouseButtonDown(0))
            {
                CameraController.ScrollRight();
            }
        }
    }
}
