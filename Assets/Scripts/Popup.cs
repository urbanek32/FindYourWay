using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts
{
    public class Popup : MonoBehaviour
    {
        private Animator _animator;
        private Text _text;

        private static Popup _instance;
        public static Popup Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Popup();
                }

                return _instance;
            }
        }

        void Awake()
        {
            if (_instance == null)
            {
                _instance = this;
            }
            else if (_instance != this)
            {
                Destroy(gameObject);
            }
        }

        void Start()
        {
            _animator = GetComponent<Animator>();
            _text = GetComponentInChildren<Text>();
        }

        public void ShowPopup(string text)
        {
            _text.text = text;
            _animator.SetTrigger("Show");
        }
    }
}
