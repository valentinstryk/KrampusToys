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
    public Image hand;
    public Sprite difHand; 
    public AudioClip pickUpSound;

    public ToyGenerator toyGenerator; 
    // public TextMeshProUGUI[] text;

    void Start()
    {
        toyGenerator.ListGenerator();
    }

    void Update()
    {
        PickToy();
    }
    
    void PickToy()
    {
        Debug.DrawRay(_playerCamera.position, _playerCamera.forward * 10f, Color.red);
        if (Input.GetKeyDown(KeyCode.E))
        {
            float pickUpDistance = 15f;
            if (Physics.Raycast(_playerCamera.position, _playerCamera.forward, out RaycastHit hit, pickUpDistance,
                    _layerMask))
            {
                Toy toy = hit.transform.GetComponentInParent<Toy>();
                if (toy != null)
                {
                    for (int i = 0; i < 5; i++)
                    {
                        if (toyGenerator.selectedWords[i].Contains(toy.gameObject.name)) // проверка по названию сохраненнного в массив имени и по имени самого объекта
                        {
                            dash[i].gameObject.SetActive(true);
                            toyGenerator.toyNames[i].fontStyle = FontStyles.Normal; 
                            toy.gameObject.SetActive(false);
                            _toyCount++;
                        }

                    }
                  
                }
            }
        }
    }

    
}