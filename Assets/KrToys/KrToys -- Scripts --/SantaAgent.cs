using System;
using DoorScript;
using UnityEngine;
using UnityEngine.AI;

public class SantaAgent : MonoBehaviour
{
    public Transform player;
    public NavMeshAgent santa;
    [SerializeField] private float updateRate = 0.2f;
    private float timer;
    [SerializeField] private float speed = 3f;

    void Start()
    {
        santa.speed = speed;
    }

    void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0f)
        {
            santa.SetDestination(player.transform.position);
            timer = updateRate;
        }
    }
}