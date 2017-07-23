using UnityEngine;
using UnityEngine.SceneManagement;

namespace Assets.Scripts
{
    public class MainMenu : MonoBehaviour
    {
        public void LoadMainGame ()
        {
            SceneManager.LoadScene("main");	
        }
    }
}
