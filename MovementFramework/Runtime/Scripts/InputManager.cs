using UnityEngine;
using UnityEngine.InputSystem;

namespace DSCore.Movement {
    public class InputManager : MonoBehaviour {
        public static Vector2 Movement { get; private set; }

        private PlayerInput _playerinput;
        private InputAction _moveAction;

        private void Awake() {
            _playerinput = GetComponent<PlayerInput>();
            _moveAction = _playerinput.actions["Move"];
        }

        private void Update() {
            Movement = _moveAction.ReadValue<Vector2>();
        }
    }
}
