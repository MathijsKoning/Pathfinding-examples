using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerNavMesh : MonoBehaviour
{
    [SerializeField] private Transform destination;
    private NavMeshAgent _agent;
    
    void Start()
    {
        _agent = GetComponent<NavMeshAgent>();
    }
    
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            _agent.destination = destination.position;
        }
    }
}
