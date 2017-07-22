using UnityEngine;

namespace Assets.Scripts
{
    public class CameraController : MonoBehaviour
    {
        public int NumberOfScenesOnLeft;
        public int NumberOfScenesOnRight;
        private int _currentScene = 0;

        public float ScreenScrollOffset = 13;
        private float _targetCameraPositionX;

        public float SmoothTimeX;
        private Vector2 _velocity;

        public GameObject Hud;
        public bool ResetCamera;

        public void ScrollRight()
        {
            if (_currentScene < NumberOfScenesOnRight)
            {
                _targetCameraPositionX += ScreenScrollOffset;
                _currentScene++;
            }
        }

        public void ScrollLeft()
        {
            if (_currentScene > (NumberOfScenesOnLeft * -1))
            {
                _targetCameraPositionX -= ScreenScrollOffset;
                _currentScene--;
            }
        }

        private void Start()
        {
            _targetCameraPositionX = Camera.main.transform.position.x;
            if (ResetCamera)
            {
                var pos = new Vector3(0, 0, -10);
                Camera.main.transform.position = pos;
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
