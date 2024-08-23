using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Move : MonoBehaviour
{
    private const string runParaname = "Run";
    [SerializeField] private float rotationSpeed;
    [SerializeField] private CharacterController characterController;
    [SerializeField] private VariableJoystick _joystick;
    [SerializeField] private float moveSpeed;
    [SerializeField] private Animator anim;
    [SerializeField] private Transform enemy;
    public UnityEvent onAttack;

    private void CharacterMove()
    {
        float hInput = _joystick.Horizontal;
        float xInput = _joystick.Vertical;
        var direction = new Vector3(hInput, characterController.velocity.y, xInput);
        direction.y = 0;
        characterController.SimpleMove(direction * moveSpeed);
        if (hInput != 0 || xInput != 0)
        {
            Quaternion targetRotation = Quaternion.LookRotation(characterController.velocity);
            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);
            anim.SetBool(runParaname, true);
        }
        if(hInput == 0 && xInput == 0)
        {
            anim.SetBool(runParaname, false);
            onAttack?.Invoke();
        }
    }
    private void Update()
    {
        CharacterMove();
    }
}
