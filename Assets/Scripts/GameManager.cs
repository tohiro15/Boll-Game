using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKey(KeyCode.Escape) && SceneManager.GetActiveScene().name != "MainMenu") SceneManager.LoadScene("MainMenu");
    }

}
