using UnityEngine;
using System.Collections.Generic;

public class DoorManager : MonoBehaviour
{
    [System.Serializable]
    public class KeyDoorPair
    {
        public GameObject keyObject;  // The specific key object
        public Animator doorAnimator; // Reference to the door's animator
        public string doorAnimationTrigger = "CollectedTrigger"; // Set to your trigger name
    }

    public List<KeyDoorPair> keyDoorPairs = new List<KeyDoorPair>();

    // Store collected keys
    private List<GameObject> collectedKeys = new List<GameObject>();

    // Method to collect key
    public void CollectKey(GameObject key)
    {
        // Add the collected key to the list
        collectedKeys.Add(key);
    }

    // Trigger the door animation if the player has collected the required key
    public void TriggerDoorAnimationForKey(GameObject collectedKey)
    {
        foreach (KeyDoorPair pair in keyDoorPairs)
        {
            if (pair.keyObject == collectedKey)
            {
                // If the player has the correct key, trigger the door's animation
                pair.doorAnimator.SetTrigger(pair.doorAnimationTrigger); // Matches your trigger name "CollectedTrigger"
                return;
            }
        }

        // If no matching door found for the key
        Debug.LogWarning("No door found for the collected key.");
    }
}

