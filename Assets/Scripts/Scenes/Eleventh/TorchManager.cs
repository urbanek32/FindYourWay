using UnityEngine;

namespace Assets.Scripts.Scenes.Eleventh
{
    public class TorchManager : MonoBehaviour
    {
        public GameObject[] ManaTorches;
        public AudioSource AudioAmbient;
        private bool _manaLighted = false;

        public GameObject[] ScrollTorches;
        private bool _scrollLighted = false;

        void Update ()
        {
            if (Equipment.Instance.HaveInInventory(Items.EXIT_SCROLL) && !_scrollLighted)
            {
                AudioAmbient.Play();
                _scrollLighted = true;
                ScrollTorches[0].SetActive(true);
                ScrollTorches[1].SetActive(true);
            }

            if (Equipment.Instance.HaveInInventory(Items.MANA_POTION) && !_manaLighted)
            {
                AudioAmbient.Play();
                _manaLighted = true;
                ManaTorches[0].SetActive(true);
                ManaTorches[1].SetActive(true);
            }
        }
    }
}
