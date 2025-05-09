using UnityEngine;

public class JumpBoost : MonoBehaviour
{
    [SerializeField] private float _jumpBoostForce = 20f;
    private void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Player")) return;

        Player player = other.GetComponentInParent<Player>();
        if (player == null) return;

        Rigidbody rb = player.GetComponent<Rigidbody>();
        if (rb == null) return;

        rb.AddForce(Vector3.up * _jumpBoostForce, ForceMode.Impulse);
    }
}
