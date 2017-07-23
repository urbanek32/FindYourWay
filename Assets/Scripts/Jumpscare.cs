using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Assets.Scripts
{
    public class Jumpscare : MonoBehaviour
    {
        public Animation Animation;
        private Animator _animator;
        private AudioSource _audio;

        private static Jumpscare _instance;
        public static Jumpscare Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Jumpscare();
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
            _audio = GetComponentInChildren<AudioSource>();
        }

        public void Show()
        {
            _audio.Play();
            _animator.SetTrigger("Show");
        }

        public void LoadAfterAnim()
        {
            SceneManager.LoadScene(0);
        }
    }
}
