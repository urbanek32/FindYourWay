using UnityEngine;
using UnityEngine.SceneManagement;

namespace Assets.Scripts
{
    public class MainMenu : MonoBehaviour
    {
        private const string RESOLUTION_KEY = "Resolution";

        void Start()
        {
            if (!PlayerPrefs.HasKey(RESOLUTION_KEY))
            {
                PlayerPrefs.SetInt(RESOLUTION_KEY, 1);
                Screen.SetResolution(1280, 720, false);
            }
        }

        public void LoadMainGame ()
        {
            SceneManager.LoadScene("main");	
        }
    }
}
