using UnityEngine;
using System.Collections;  // Add this line to include the necessary namespace

public class DisableUIPanel : MonoBehaviour
{
    // The time (in seconds) after which the UI panel should be disabled
    public float disableTime = 5f;

    // Reference to the UI panel GameObject
    private GameObject uiPanel;

    void Start()
    {
        // Get the GameObject to which this script is attached
        uiPanel = gameObject;

        // Start the coroutine to disable the UI panel after the specified time
        StartCoroutine(DisableAfterTime(disableTime));
    }

    private IEnumerator DisableAfterTime(float time)
    {
        // Wait for the specified time
        yield return new WaitForSeconds(time);

        // Disable the UI panel
        uiPanel.SetActive(false);
    }
}
