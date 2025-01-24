using System;
using UnityEngine;
using UnityEngine.Serialization;

public class BasePlayer : BaseCharacter
{
    [SerializeField]
    private VariableJoystick _joystick;
    
    [SerializeField]
    private Rigidbody _rb;
    
    [Header("Move")]
    [SerializeField]
    private float _moveSpeed;
    
    [Header("Anim")]
    [SerializeField]
    private Animator _animator;

    private void FixedUpdate()
    {
        Moving();
    }
    private void Moving()
    {
        var horizontal = _joystick.Horizontal;
        var vertical = _joystick.Vertical;
        
        _rb.linearVelocity = new Vector3(horizontal * _moveSpeed, _rb.linearVelocity.y, vertical * _moveSpeed);

        transform.rotation = Quaternion.LookRotation(new Vector3(horizontal, 0, vertical));
        
        float speed = new Vector2(horizontal, vertical).magnitude;
        _animator.SetFloat("Speed", speed);
    }
}
