using UnityEngine;

namespace KrToys
{
    public class PlayerCollision : MonoBehaviour
    {
        public UIService uiService;
        public AudioService audioService;
        
        
        void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.GetComponent<SantaAgent>() == false) return;
            uiService.ShowLoseUI();
            audioService.PlayLoseSound();
            
        }
    }
}