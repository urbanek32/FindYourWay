using UnityEngine;

namespace Assets.Scripts.Scenes.Eleventh
{
    public class TorchManager : MonoBehaviour
    {
        public GameObject[] ManaTorches;
        private bool _manaLighted = false;

        public GameObject[] ScrollTorches;
        private bool _scrollLighted = false;

        void Update ()
        {
            if (Equipment.Instance.HaveInInventory(Items.EXIT_SCROLL) && !_scrollLighted)
            {
                _scrollLighted = true;
                ScrollTorches[0].SetActive(true);
                ScrollTorches[1].SetActive(true);
            }

            if (Equipment.Instance.HaveInInventory(Items.MANA_POTION) && !_manaLighted)
            {
                _manaLighted = true;
                ManaTorches[0].SetActive(true);
                ManaTorches[1].SetActive(true);
            }
        }
    }
}
