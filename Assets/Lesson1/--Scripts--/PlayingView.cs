using UnityEngine;

namespace Lesson1.__Scripts__
{
    public class PlayingView : MonoBehaviour
    {
        public GameObject airDropNet;

        public void DisableNet()
        {
            airDropNet.SetActive(false);
        }
    }
    
    
}