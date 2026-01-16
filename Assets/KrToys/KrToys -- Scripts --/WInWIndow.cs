using DoorScript;
using KrToys;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class WInWIndow : MonoBehaviour
{
    public Canvas _canvas;
    public PlayerMovement playerMovement;
    public Button btnRestart;
    public PickingToy t;
    public TextMeshProUGUI text;
    public TextMeshProUGUI text2;
    public ToyGenerator toyGen;
    public ToyConfigSO _config;
    public Door door;
    
    private float _timer = 0;


    void Start()
    {
        btnRestart.onClick.AddListener(Restart);
        _config = Resources.Load<ToyConfigSO>("ToyConfig");
    }

    void OnTriggerEnter(Collider other)
    {
        _canvas.gameObject.SetActive(true);
        playerMovement.StopPlayer(true);
        text.text = ($"FINDED TOYS - {t._toyCount} / 5");
       // text2.text = _timer.ToString("0.0"); 
        Cursor.visible = true;
        playerMovement._controller.enabled = false;

    }

    void Restart()
    {
        _canvas.gameObject.SetActive(false);
        playerMovement.StopPlayer(false);
        playerMovement.player.localPosition = new Vector3(0f, 0.5f, 0f);
        t._toyCount = 0;
        _timer = 0;
        toyGen.ListGenerator();

        foreach (TextMeshProUGUI names in toyGen.toyNames)
        {
            names.fontStyle = FontStyles.Bold;
        }

        foreach (var d in t.dash)
        {
            d.gameObject.SetActive(false);
        }

        playerMovement._controller.enabled = true;
        toyGen.ClearAllToys();
        toyGen.SpawnProduct(_config.toys.Length);
        door.CloseDoor();
    }

    void Update()
    {
      //  _timer++;
    }

    

}