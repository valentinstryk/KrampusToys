using UnityEngine;
using UnityEngine.UI;

public class UIService : MonoBehaviour
{
    public GameObject winUI;
    public GameObject startUI;
    public GameObject loseUI;

    [SerializeField] private Button btnStart;
    //[SerializeField] private Button btnRestart;
    //public WInWIndow winWindow;
    //public PlayerMovement player;

    public void ShowWinUI()
    {
        winUI.SetActive(true);
        // player.StopPlayer(true);
    }

    public void HideWinUI()
    {
        winUI.SetActive(false);
    }

    public void HideStartUI()
    {
        startUI.SetActive(false);
        Cursor.visible = false;
    }

    public void ShowLoseUI()
    {
        loseUI.SetActive(true);
    }

    public void HideLoseUI()
    {
        loseUI.SetActive(false);
    }
}