using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class PlayerMouseController : MonoBehaviour, ITurning
{
    [Header("Camera Settings")]
    [Space]

    [SerializeField] private Transform _target;
    [SerializeField] private float _mouseSensitivity = 250f;
    [SerializeField] private float _distanceFromCamera = 5f;

    [SerializeField] private float _minY = 0;
    [SerializeField] private float _maxY = 89.9f;

    private float rotationX;
    private float rotationY;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;

        if (_target == null) _target = gameObject.transform.parent;
    }

    public void Turning()
    {
        rotationX += Input.GetAxis("Mouse X") * _mouseSensitivity * Time.deltaTime;
        rotationY -= Input.GetAxis("Mouse Y") * _mouseSensitivity * Time.deltaTime;
        rotationY = Mathf.Clamp(rotationY, _minY, _maxY);

        Quaternion rotation = Quaternion.Euler(rotationY, rotationX, 0);

        Vector3 offsetPosition = rotation * new Vector3(0, 0, -_distanceFromCamera);

        transform.position = _target.position + offsetPosition;
        transform.LookAt(_target);
    }
}
