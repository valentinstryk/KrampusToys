using UnityEngine;

public class UIService : MonoBehaviour
{
    public GameObject winUI;
    public GameObject startUI;
    
    public void ShowWinUI()
    {
        winUI.SetActive(true);
    }

    public void HideWinUI()
    {
        winUI.SetActive(false);
    }
}
