using UnityEngine;

[RequireComponent (typeof(Rigidbody2D))]
[RequireComponent(typeof(Animator))]
public abstract class MovementBase : MonoBehaviour
{
    // --- Movement Variables ---
    [SerializeField] protected float _moveSpeed = 2f;
    protected Vector2 _movement;

    // --- Components ---
    protected Rigidbody2D _rb;
    protected Animator _animator;

    // --- Animation Parameter Names ---
    protected const string Horizontal = "Horizontal";
    protected const string Vertical = "Vertical";
    protected const string LastHorizontal = "LastHorizontal";
    protected const string LastVertical = "LastVertical";

    protected virtual void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
        _animator = GetComponent<Animator>();
    }

    protected virtual void Update()
    {
        HandleMovementInput();
        AnimateMovement();
    }

    protected abstract void HandleMovementInput();

    protected virtual void AnimateMovement()
    {
        _animator.SetFloat(Horizontal, _movement.x);
        _animator.SetFloat(Vertical, _movement.y);

        if (_movement != Vector2.zero)
        {
            _animator.SetFloat(LastHorizontal, _movement.x);
            _animator.SetFloat(LastVertical, _movement.y);
        }
    }
}
