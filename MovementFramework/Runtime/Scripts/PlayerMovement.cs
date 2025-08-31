namespace DSCore.Movement {
    public class PlayerMovement : MovementBase {
        protected override void HandleMovementInput() {
            _movement.Set(InputManager.Movement.x, InputManager.Movement.y);
            _rb.linearVelocity = _movement * _moveSpeed;
        }
    }
}
