using UnityEngine;
using UnityEngine.SceneManagement;

public class ColliderScript : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            RestartLevel();
        }
    }

    private void RestartLevel()
    {
        // Reloads the currently active scene
        SceneManager.LoadScene("Playground");
    }
}
