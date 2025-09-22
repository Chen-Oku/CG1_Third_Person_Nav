using System;
using UnityEngine;
using UnityEngine.AI;

public class AgentMovement : MonoBehaviour
{
    [SerializeField] NavMeshAgent agent; // Reference to the NavMeshAgent component
    public event Action<float> OnSpeedChanged;

    // Update is called once per frame
    void Update()
    {
        OnSpeedChanged?.Invoke(Mathf.Clamp01(agent.velocity.magnitude / agent.speed));
    }

    public void SetDestination(Vector3 destination)
    {
        agent.destination = destination;
    }
}
