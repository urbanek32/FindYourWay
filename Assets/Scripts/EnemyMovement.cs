using UnityEngine;

namespace Assets.Scripts
{
    public class EnemyMovement : MonoBehaviour
    {
        public SpriteRenderer Renderer;
        public GameObject[] Waypoints;

        private Vector3 _currentTarget;
        private int _waypointIndex;
        public float Speed;

        void Start ()
        {
            _currentTarget = Waypoints[_waypointIndex++].transform.position;
        }

        void Update ()
        {
            if (Vector3.Distance(transform.position, _currentTarget) < 0.5f)
            {
                _currentTarget = Waypoints[_waypointIndex++].transform.position;
                Renderer.flipX = _waypointIndex%2 == 0;
            }

            if (_waypointIndex >= Waypoints.Length)
            {
                _waypointIndex = 0;
            }
            
            var m = Vector3.MoveTowards(transform.position, _currentTarget, Speed * Time.deltaTime);
            transform.position = m;
        }

        void OnMouseEnter()
        {
            Jumpscare.Instance.Show();
        }
    }
}
