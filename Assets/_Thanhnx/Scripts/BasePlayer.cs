using UnityEngine;

public class BasePlayer : BaseCharacter
{
    [SerializeField] private VariableJoystick _joystick;
    [SerializeField] private Rigidbody _rb;
    [SerializeField] private float _moveSpeed;
    [SerializeField] private Animator _animator;

    private Vector3 _movement;
    private float _speed;

    private void FixedUpdate()
    {
        Moving();
    }

    private void Moving()
    {
        float horizontal = _joystick.Horizontal;
        float vertical = _joystick.Vertical;

        if (Mathf.Abs(horizontal) < 0.01f && Mathf.Abs(vertical) < 0.01f)
        {
            _rb.velocity = new Vector3(0, _rb.velocity.y, 0);
            _animator.SetFloat("Speed", 0);
            return;
        }

        _movement.Set(horizontal, 0, vertical);
        _movement.Normalize(); // Đảm bảo di chuyển có tốc độ nhất quán
        _rb.velocity = new Vector3(_movement.x * _moveSpeed, _rb.velocity.y, _movement.z * _moveSpeed);

        transform.rotation = Quaternion.LookRotation(_movement);

        _speed = _movement.magnitude;
        if (_animator.GetFloat("Speed") != _speed)
        {
            _animator.SetFloat("Speed", _speed);
        }
    }
}
