using System;
using Unity.VisualScripting;
using UnityEngine;

public class Toy : MonoBehaviour
{
    public ToyItem data;
    
  
    public void Init(ToyItem toyItem)
    {
        data = toyItem;
    }
   
}