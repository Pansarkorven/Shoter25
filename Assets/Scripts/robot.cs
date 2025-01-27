using StarterAssets;
using UnityEngine;
using UnityEngine.AI;

public class robot : MonoBehaviour
{

    NavMeshAgent agant;
    FirstPersonController player;
    

    void Awake()
    {
        agant = GetComponent<NavMeshAgent>();
    }
    void Start()
    {
        player = FindFirstObjectByType<FirstPersonController>();
    }

    void Update()
    {
        agant.SetDestination(player.transform.position);
    }

}
