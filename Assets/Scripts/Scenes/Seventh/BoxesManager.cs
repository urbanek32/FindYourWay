using UnityEngine;

namespace Assets.Scripts.Scenes.Seventh
{
    public class BoxesManager : MonoBehaviour
    {
        public Box[] Boxes;

        void Start ()
        {
            int index = Random.Range(0, Boxes.Length);
            Boxes[index].IsCorrect = true;
        }
    }
}
