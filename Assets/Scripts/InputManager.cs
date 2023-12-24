using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    PlayerControls playercontrols;
    AnimatorManager animatormanager;
    public Vector2 movementInput;
    private float moveAmount;
    public float verticalInput;
    public float horizontalInput;
    public Animator animator;

    private void Awake()
    {
        animatormanager = GetComponent<AnimatorManager>();
        //animator = GetComponent<Animator>();
    }
    private void OnEnable()
    {
        if(playercontrols == null)
        {
            playercontrols = new PlayerControls();

            playercontrols.PlayerMovement.Movement.performed += i => movementInput = i.ReadValue<Vector2>();

        }

        playercontrols.Enable();

    }

    private void OnDisable()
    {
        playercontrols.Disable();
    }

    public void HandleAllInputs()
    {
        HandleMovementInput();
    }

    private void HandleMovementInput()
    {
        verticalInput = movementInput.y;
        horizontalInput = movementInput.x;
        moveAmount=Mathf.Clamp01(Mathf.Abs(horizontalInput)+ Mathf.Abs(verticalInput));
        animatormanager.UpdateAnimatorValues(0, moveAmount);
    }
}
