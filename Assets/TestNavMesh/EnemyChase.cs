using UnityEngine;
using UnityEngine.AI;

public class EnemyChase : MonoBehaviour
{
    private NavMeshAgent agent;
    public GameObject player;
    [SerializeField] private float updateRate = 0.2f;
    private float timer;
    
    void Awake()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    void Start()
    {
    }

    void Update()
    {
        if (player == null)
            return;

        timer -= Time.deltaTime;
        if (timer <= 0f)
        {
            agent.SetDestination(player.transform.position);
            timer = updateRate;
        }
    }
}