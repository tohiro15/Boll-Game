using UnityEngine;

public class CoinPickup : MonoBehaviour, IPickup
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            ObjectPickup();
        }
    }
    public void ObjectPickup()
    {
        Destroy(gameObject);
    }
}
