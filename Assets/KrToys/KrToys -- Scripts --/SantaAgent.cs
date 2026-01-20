using System;
using DoorScript;
using UnityEngine;
using UnityEngine.AI;

public class SantaAgent : MonoBehaviour
{
    public Transform player;
    NavMeshAgent santa;
    
    void Start()
    {
        santa = GetComponent<NavMeshAgent>();
    }
    
    void Update()
    {
        santa.SetDestination(player.position);
    }

    
}
