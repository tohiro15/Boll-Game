using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private PlayerMovementController _playerMovementCtr;
    [SerializeField] private PlayerMouseController _playerTurningCtr;
    [SerializeField] private PlayerDeath—heck _playerCheckForDeath;

    private IMovable _movable;
    private ITurning _turning;
    private IDeath _death;
    private void Start()
    {
        _playerMovementCtr = GetComponent<PlayerMovementController>();
        _movable = _playerMovementCtr;

        _playerTurningCtr = GetComponentInChildren<PlayerMouseController>();
        _turning = _playerTurningCtr;

        _playerCheckForDeath = GetComponentInChildren<PlayerDeath—heck>();
        _death = _playerCheckForDeath;

    }
    private void FixedUpdate()
    {
        _movable?.Move();
    }
    private void Update()
    {
        _turning?.Turning();
        _death?.UndergroundCheck();
    }
}
