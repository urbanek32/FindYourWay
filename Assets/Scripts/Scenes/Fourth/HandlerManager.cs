using UnityEngine;

namespace Assets.Scripts.Scenes.Fourth
{
    public class HandlerManager : MonoBehaviour
    {
        public Handler[] Handlers;

        void Start ()
        {
            var index = Random.Range(0, Handlers.Length);
            Handlers[index].IsCorrect = true;
        }
    }
}
