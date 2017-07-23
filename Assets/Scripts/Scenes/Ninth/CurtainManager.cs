using UnityEngine;

namespace Assets.Scripts.Scenes.Ninth
{
    public class CurtainManager : MonoBehaviour
    {
        public Curtain[] Curtains;

        void Start ()
        {
            var index = Random.Range(0, Curtains.Length);
            Curtains[index].IsCorrect = true;
        }
    }
}
