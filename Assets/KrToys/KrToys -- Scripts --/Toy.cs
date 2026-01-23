using System;
using Unity.VisualScripting;
using UnityEngine;

public class Toy : MonoBehaviour
{
    public ToyItem data;
    private AudioSource _audioSource;

    private void Start()
    {
        _audioSource = GetComponent<AudioSource>();
    }

    public void Init(ToyItem toyItem)
    {
        data = toyItem;
    }

    public AudioClip GetClip()
    {
        return _audioSource.clip;
    }
}