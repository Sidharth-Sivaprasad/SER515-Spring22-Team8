using UnityEngine;
using System.Collections;
public class SampleAgentScript : MonoBehaviour
{
    public Transform target;
    UnityEngine.AI.NavMeshAgent agent;
    void Start()
    {
        agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
    }
    void Update()
    {
        agent.SetDestination(target.position);
    }
}

