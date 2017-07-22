using UnityEngine;

namespace Assets.Scripts
{
    public class LeftScreenScroller : MonoBehaviour
    {
        public CameraController CameraController;

        void OnMouseOver()
        {
            if (Input.GetMouseButtonDown(0))
            {
                CameraController.ScrollLeft();
            }
        }
    }
}
