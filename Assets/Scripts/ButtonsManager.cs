using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonsManager : MonoBehaviour
{
    [SerializeField] private string _sceneName;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            LevelChange(_sceneName);
        }
    }
    public void LevelChange(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
