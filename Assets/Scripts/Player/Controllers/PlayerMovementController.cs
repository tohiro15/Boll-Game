using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerMovementController : MonoBehaviour, IMovable
{
    [Header("Settings")]
    [Space]

    [SerializeField] private Camera _playerCamera;
    [SerializeField] private float _speed = 20f;

    [Header("Components")]
    [Space]

    [SerializeField] private Rigidbody _rb;

    private float _moveX;
    private float _moveZ;
    private void Start()
    {
        _rb = GetComponent<Rigidbody>();
        if (_rb == null) Debug.LogWarning("Rigidbody - not found!");

        _playerCamera = GetComponentInChildren<Camera>();
        if(_playerCamera == null ) _playerCamera = Camera.main;
    }
    public void Move()
    {
        _moveX = Input.GetAxis("Horizontal");
        _moveZ = Input.GetAxis("Vertical");

        _rb.AddForce(_playerCamera.transform.forward * _moveZ * _speed * Time.deltaTime, ForceMode.Impulse);
        _rb.AddForce(_playerCamera.transform.right * _moveX * _speed * Time.deltaTime, ForceMode.Impulse);
    }
}
