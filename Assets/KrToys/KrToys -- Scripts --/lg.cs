using KrToys;
using UnityEngine;

public class lg : MonoBehaviour
{
    public ToyGenerator ToyGenerator;
    public string[] toyList;
    private ToyConfigSO _config;
    public GameObject tempValue;
    public ToyItem[] toys;

    void Start()
    {
        _config = Resources.Load<ToyConfigSO>("ToyConfig");
    }
}