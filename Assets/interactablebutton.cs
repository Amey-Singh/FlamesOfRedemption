using UnityEngine;
using UnityEngine.UI;

public class InteractButtonController : MonoBehaviour
{
    public Button interactButton; // Reference to your interact button in the UI Canvas

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Check if the collided object is interactable
        if (collision.CompareTag("Interactable"))
        {
            // Enable the interact button
            interactButton.gameObject.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        // Check if the collided object is interactable
        if (collision.CompareTag("Interactable"))
        {
            // Disable the interact button
            interactButton.gameObject.SetActive(false);
        }
    }
}
