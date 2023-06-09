using UnityEngine;
using TMPro;

public class DisplayCurrentRunTime : MonoBehaviour
{
    public TMP_Text currentRunTimeText;

    private void Update()
    {
        float currentRunTime = Timer.timer;

        string currentRunTimeMinutes = Mathf.Floor(currentRunTime / 60).ToString("00");
        string currentRunTimeSeconds = Mathf.Floor(currentRunTime % 60).ToString("00");
        currentRunTimeText.text = "Current Run Time: " + currentRunTimeMinutes + ":" + currentRunTimeSeconds;
    }
}
