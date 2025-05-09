using UnityEngine;

public class SpeedBooster : MonoBehaviour
{
    [SerializeField] private float _speedBoostForce = 20f;

    private void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Player")) return;

        Player player = other.GetComponentInParent<Player>();
        if (player == null) return;

        Rigidbody rb = player.GetComponent<Rigidbody>();
        if (rb == null) return;

        rb.AddForce(transform.localRotation * Vector3.up * _speedBoostForce, ForceMode.Impulse);
    }
}
