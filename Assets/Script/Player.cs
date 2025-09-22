using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] PlayerInput input;
    [SerializeField] AgentMovement agentMovement;
    [SerializeField] AgentAnimation agentAnimation;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        input.OnMouseClick += agentMovement.SetDestination;
        agentMovement.OnSpeedChanged += agentAnimation.SetSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
