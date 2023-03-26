using UnityEngine;

namespace Flower
{
    [SerializeField]
    public class LevelPath : MonoBehaviour
    {
        [SerializeField]
        private Transform[] pathNodes;

        public Transform[] PathNodes
        {
            get
            {
                return pathNodes;
            }
        }
    }

}