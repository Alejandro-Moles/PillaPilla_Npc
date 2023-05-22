using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class MoveNpc : MonoBehaviour
{
    private NavMeshAgent navAgent;
    public Transform Player;
    public GameObject PanelDerrota;
    void Start()
    {
        navAgent = GetComponent<NavMeshAgent>();
    }

    
    void Update()
    {
        navAgent.SetDestination(Player.position);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            SceneManager.LoadScene("Derrota");
        }
    }
}
