using NUnit.Framework;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    InputManager inputManager;
    PlayerMovement playerMovement;
    Animator animator;

    public bool isInteracting;

    private void Awake()
    {
        inputManager = GetComponent<InputManager>();
        playerMovement = GetComponent<PlayerMovement>();
        animator = GetComponent<Animator>();

    }

    void Update()
    {
        inputManager.HandleAllInputs();
    }

    private void FixedUpdate() //tiene pasos definidos que no dependen de los fps
    {
        playerMovement.HandleAllMovement();
    }

    private void LateUpdate() //se ejecuta al final de todo
    {
        isInteracting = animator.GetBool("isInteracting");
    }

}
