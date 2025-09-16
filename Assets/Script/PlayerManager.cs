using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    InputManager inputManager;
    PlayerMovement playerMovement;

    private void Awake()
    {
        inputManager = GetComponent<InputManager>();
        playerMovement = GetComponent<PlayerMovement>();
    }

    void Update()
    {
        inputManager.HandleAllInputs();

    }

    private void FixedUpdate() //tiene pasos definidos que no dependen de los fps
    {
        playerMovement.HandleAllMovement();
    }

}
