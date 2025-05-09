using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonLevelChange : MonoBehaviour, IChangingScene
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            LevelChange();
        }
    }
    public void LevelChange()
    {
        Scene currentScene = SceneManager.GetActiveScene();

        int nextScene = currentScene.buildIndex + 1;
        if (nextScene > SceneManager.sceneCountInBuildSettings) return;

        SceneManager.LoadScene(nextScene);
    }
}
