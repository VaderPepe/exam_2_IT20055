using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class FailSafe : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            SceneManager.LoadScene("Start");
        }
    }
}