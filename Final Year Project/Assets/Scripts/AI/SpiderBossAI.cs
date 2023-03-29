using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class SpiderBossAI : MonoBehaviour
{
    public GameObject destination;
    NavMeshAgent spiderAgent;


    
    void Start()
    {
        spiderAgent = GetComponent<NavMeshAgent>();
    }

    
    void Update()
    {
        spiderAgent.SetDestination(destination.transform.position);
    }
}
