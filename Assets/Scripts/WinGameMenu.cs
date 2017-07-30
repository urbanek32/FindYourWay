using UnityEngine;
using UnityEngine.SceneManagement;

namespace Assets.Scripts
{
    public class WinGameMenu : MonoBehaviour
    {
        public void LoadMainMenu()
        {
            SceneManager.LoadScene(0);
        }
    }
}
