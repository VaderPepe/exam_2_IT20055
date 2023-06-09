using UnityEngine;
using UnityEngine.UI;

public class ClearHighScore : MonoBehaviour
{
    public void OnClearButtonClicked()
    {
        PlayerPrefs.DeleteKey("HighScore");
    }
}
