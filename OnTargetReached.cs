using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

// 
public class OnTargetReached : MonoBehaviour
{
    
    public float threshold = 0.02f; // Final point till where slider can slide  before shooting;
    public Transform target;
    public UnityEvent OnReached;
    private bool wasReached = false;

    private void FixedUpdate()
    {
        // To check if the transform position of this game object is the same as the targets;
        float distance = Vector3.Distance(transform.position, target.position);

        //if the distance less than threshold and target was not reached 
        if(distance < threshold && !wasReached) 
        {
            // Reached the target
            OnReached.Invoke();
            wasReached = true;
        }
        else if(distance >= threshold)
        {
            wasReached = false;
        }
    }
}
