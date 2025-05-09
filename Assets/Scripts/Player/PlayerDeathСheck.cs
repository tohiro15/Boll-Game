using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerDeathСheck : MonoBehaviour, IDeath
{
    [SerializeField] private Transform _target;

    private void Start()
    {
        _target = transform;
    }

    public void UndergroundCheck()
    {
        if (_target.transform.position.y < 0)
        {
            Scene currentScene = SceneManager.GetActiveScene();
            SceneManager.LoadScene(currentScene.name);
        }
    }
}
