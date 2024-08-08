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
    [SerializeField] private float whiteToEnemy;
    [SerializeField] private float redToEnemy;
    public UnityEvent onWhiteIndicator;
    public UnityEvent onRedIndicator;
    public UnityEvent onShoot;

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
        else
        {
            anim.SetBool(runParaname, false);
            OnIndicator();
            onShoot?.Invoke();
        }
    }

    private void OnIndicator()
    {
        var indicator = Vector3.Distance(transform.position, enemy.position);
        if(indicator <= whiteToEnemy && indicator > redToEnemy)
        {
            onWhiteIndicator?.Invoke();
        }
        else if(indicator <= redToEnemy)
        {
            onRedIndicator?.Invoke();
            anim.SetTrigger("Aiming");
            transform.LookAt(enemy);
        }    
    }
    private void Update()
    {
        CharacterMove();
    }
    private void OnDrawGizmos()
    {
        Color rangeAttack = Color.black;
        Gizmos.DrawSphere(transform.position, redToEnemy);
        Gizmos.DrawSphere(transform.position, whiteToEnemy);
    }
}
