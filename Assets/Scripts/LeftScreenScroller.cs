using UnityEngine;

namespace Assets.Scripts
{
    public class LeftScreenScroller : MonoBehaviour
    {
        public CameraController CameraController;
        public SpriteRenderer Renderer;
        public BoxCollider2D Collider;

        void Update()
        {
            if (CameraController.CurrentScene == -4)
            {
                if (CameraController.NumberOfScenesOnLeft == 5)
                {
                    return;
                }

                Renderer.enabled = false;
                Collider.enabled = false;
            }
            else
            {
                if (CameraController.CurrentScene == -5)
                {
                    Renderer.enabled = false;
                    Collider.enabled = false;
                    return;
                }

                Collider.enabled = true;
                Renderer.enabled = true;
            }
        }

        void OnMouseOver()
        {
            if (Input.GetMouseButtonDown(0))
            {
                CameraController.ScrollLeft();
            }
        }
    }
}
