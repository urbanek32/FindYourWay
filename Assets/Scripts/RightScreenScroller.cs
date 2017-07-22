using UnityEngine;

namespace Assets.Scripts
{
    public class RightScreenScroller : MonoBehaviour
    {
        public CameraController CameraController;

        void OnMouseOver()
        {
            if (Input.GetMouseButtonDown(0))
            {
                CameraController.ScrollRight();
            }
        }
    }
}
