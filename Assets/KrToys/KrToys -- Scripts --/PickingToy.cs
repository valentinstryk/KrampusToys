using KrToys;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class PickingToy : MonoBehaviour
{
    [SerializeField] private Transform _playerCamera;
    [SerializeField] private LayerMask _layerMask;
    public int _toyCount = 0;
    private ToyItem[] toys;
    private ToyConfigSO _config;
    public Image[] dash;
    float pickUpDistance = 15f;
    public UIService uiService;
    public AudioService audioService;

    public ToyGenerator toyGenerator;
    // public TextMeshProUGUI[] text;

    void Start()
    {
        toyGenerator.ListGenerator();
    }

    void Update()
    {
        PickToy();
        Debug.DrawRay(_playerCamera.position, _playerCamera.forward * 10f, Color.red);
    }

    void PickToy()
    {
        if (Input.GetKeyDown(KeyCode.E) == false) return;
        if (Physics.Raycast(_playerCamera.position, _playerCamera.forward, out RaycastHit hit, pickUpDistance,
                _layerMask) == false) return;

        Toy toy = hit.transform.GetComponentInParent<Toy>();
        if (toy == null) return;


        if (toyGenerator.selectedWords.Contains(toy.gameObject.name) == false) return; // проверка по названию сохраненнного в массив имени и по имени самого объекта
       //  dash[i].gameObject.SetActive(true);
       // toyGenerator.toyNames[i].fontStyle = FontStyles.Normal; 
        dash[toyGenerator.selectedWords.IndexOf(toy.gameObject.name)].gameObject.SetActive(true);
        toy.gameObject.SetActive(false);
        _toyCount++;
        audioService.PlayCollectSound();
        CheckGameResult();
    }

    void CheckGameResult()
    {
        if (_toyCount >= 5)
        {
            uiService.ShowWinUI();
        }
    }

    //Тест гит проверка - 1
}