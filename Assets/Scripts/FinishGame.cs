using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class FinishGame : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            float currentTime = Timer.timer;
            float previousHighScore = PlayerPrefs.GetFloat("HighScore", Mathf.Infinity);

            if (currentTime < previousHighScore)
            {
                PlayerPrefs.SetFloat("HighScore", currentTime);
            }

            SceneManager.LoadScene("Finished");
        }
    }
}
