using UnityEngine;

public class ButtonExitGame : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player")) Application.Quit();
    }
}
