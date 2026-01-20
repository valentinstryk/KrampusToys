using System;
using DoorScript;
using UnityEngine;

public class DoorForAgent : MonoBehaviour
{
    public Door door;
    public SantaAgent sg;

    private void OnTriggerEnter(Collider other)
    {
        
            door.OpenDoor();
    }

    private void OnTriggerExit(Collider other)
    {
       
            door.CloseDoor();
    }
}