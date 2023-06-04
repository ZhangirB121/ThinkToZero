using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lever : MonoBehaviour
{
    bool isTurned = false;
    [SerializeField] private Animator leverAnimation = null;
    public GameObject targetObject;

    private void Start()
    {
        // Make sure to assign the Animation component to the leverAnimation variable in the Inspector.
        // Additionally, assign the target object that you want to interact with when the lever is clicked.
    }

    private void OnMouseDown() {
        if (Input.GetMouseButtonDown(0)) {
            if (!isTurned) {
                Debug.Log("Mouse clicked on lever");
                leverAnimation.Play("Idle");
                targetObject.SetActive(true); // Activate or perform some action on the target object
            }
            else {
                Debug.Log("Mouse clicked on lever");
                leverAnimation.Play("LeverUp");
                targetObject.SetActive(false); // Deactivate or undo the action on the target object
            }

            isTurned = !isTurned;
        }
    }
}