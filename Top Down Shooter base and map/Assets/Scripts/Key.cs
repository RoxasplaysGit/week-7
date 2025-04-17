using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Key : MonoBehaviour
{
    public DoorManager doorManager;

    private void OnTriggerEnter2D(Collider2D other)
    {
        //Check if the player collides w the key
        if(other.CompareTag("Player"))
        {
            //add this key to the DoorManager's Collected Keys
            doorManager.CollectKey(gameObject);

            //Tell the DoorMAnager to trigger the door animation
            doorManager.TriggerDoorAnimationForKey(gameObject);

            //destroy the key object after its collected
            Destroy(gameObject);
        }
    }
}
