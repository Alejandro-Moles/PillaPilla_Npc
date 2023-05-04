using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MoveNpc : MonoBehaviour
{
    private NavMeshAgent navAgent;
    public Transform Player;
    void Start()
    {
        navAgent = GetComponent<NavMeshAgent>();
    }

    
    void Update()
    {
        navAgent.SetDestination(Player.position);
    }
}
