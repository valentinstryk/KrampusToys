using DoorScript;
using KrToys;
using TMPro;
using UnityEngine;
using UnityEngine.UIElements;
using Button = UnityEngine.UI.Button;
using Cursor = UnityEngine.Cursor;

public class WInWIndow : MonoBehaviour
{
    public Canvas _canvas;
    public PlayerMovement playerMovement;
    public Button btnRestart;
    public PickingToy t;
   // public TextMeshProUGUI text;
   // public TextMeshProUGUI text2;
    public ToyGenerator toyGen;
    public ToyConfigSO _config;
    public Door door;
    public UIService uiService;
    public Button btnRestart2;
    public AudioService audioService; 
    
    private float _timer = 0;


    void Start()
    {
        btnRestart.onClick.AddListener(Restart);
        btnRestart2.onClick.AddListener(Restart);
        _config = Resources.Load<ToyConfigSO>("ToyConfig");
    }

    // void OnTriggerEnter(Collider other)
  //  {
       // _canvas.gameObject.SetActive(true);
        // playerMovement.StopPlayer(true);
        //text.text = ($"FINDED TOYS - {t._toyCount} / 5");
       // text2.text = _timer.ToString("0.0"); 
        //Cursor.visible = true;
        // playerMovement._controller.enabled = false;

   // }

    public void Restart()
    {
        _canvas.gameObject.SetActive(false);
        playerMovement.player.localPosition = new Vector3(0, 0.5f, 0);
        t._toyCount = 0;
        _timer = 0;
        toyGen.ListGenerator();

        audioService.audioSourceBg.mute = false;

        foreach (TextMeshProUGUI names in toyGen.toyNames)
        {
            names.fontStyle = FontStyles.Bold;
        }

        foreach (var d in t.dash)
        {
            d.gameObject.SetActive(false);
        }
        
        toyGen.ClearAllToys();
        toyGen.SpawnProduct(_config.toys.Length);
        door.CloseDoor();
        uiService.HideWinUI();
        playerMovement.StopPlayer(false);
        playerMovement._controller.enabled = true; 
        

    }

    void Update()
    {
      //  _timer++;
    }

    

}