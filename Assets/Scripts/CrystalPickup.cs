using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrystalPickup : MonoBehaviour
{
    private bool isCollected = false;

    [Header("UI Event")]
    public GameObject uiEventObject; // Reference to the UI element (e.g., score display)
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other) 
    {
        if (other.CompareTag("Player") && !isCollected)
        {
            // Handle pickup logic (e.g., increase score, play sound, etc.)
            // Example: GameManager.Instance.IncreaseScore();

            // Hide the pickup item
            isCollected = true;
            gameObject.SetActive(false);

            // Trigger UI event (e.g., update score UI)
            if (uiEventObject != null)
            {
                // Example: uiEventObject.GetComponent<ScoreUI>().UpdateScore();
            }
        }
    }
}
