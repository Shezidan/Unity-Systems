# Unity Movement Framework

Abstract top down 2D movement framework handling character motion and movement animation.

## Features 
- Flexible movement logic adaptable for player input, enemy AI, or other behaviours.
- Derived classes can override HandleMovement() to implement custom behaviors effortlessly.

## Setup
- Animator with 2D directional blend trees (parameters: "Horizontal", "Vertical", "LastHorizontal", "LastVertical").
- Rigidbody2D with gravity disabled for top-down movement.

# Unity Input Manager

System for converting Unity Input System values into a reusable Vector2.

## Example Usage
Use alongside the Unity Movement System to implement player movement:

```csharp
public class PlayerMovement : MovementBase
{
    protected override void HandleMovementInput()
    {
        _movement.Set(InputManager.Movement.x, InputManager.Movement.y);
        _rb.linearVelocity = _movement * _moveSpeed;
    }
}


