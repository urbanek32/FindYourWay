using UnityEngine;

namespace Assets.Scripts
{
    public class CameraController : MonoBehaviour
    {
        public int NumberOfScenes;
        private int _currentScene = 1;

        public float ScreenScrollOffset = 13;
        private float _targetCameraPositionX;

        public float SmoothTimeX;
        private Vector2 _velocity;

        public GameObject Hud;

        public void ScrollRight()
        {
            if (_currentScene < NumberOfScenes)
            {
                _targetCameraPositionX += ScreenScrollOffset;
                _currentScene++;
            }
        }

        public void ScrollLeft()
        {
            if (_currentScene >= 2)
            {
                _targetCameraPositionX -= ScreenScrollOffset;
                _currentScene--;
            }
        }

        private void Update()
        {
            var posX = Mathf.SmoothDamp(transform.position.x, _targetCameraPositionX, ref _velocity.x, SmoothTimeX);

            transform.position = new Vector3(posX, transform.position.y, transform.position.z);
            Hud.transform.position = new Vector2(posX, transform.position.y);
        }
    }
}
