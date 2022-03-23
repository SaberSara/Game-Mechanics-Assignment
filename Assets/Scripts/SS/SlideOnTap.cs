using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlideOnTap : MonoBehaviour
{
    
    private CharacterController characterController;

    void Start()
    {
        characterController = GetComponent<CharacterController>();
        characterController.characterDirection = transform.position;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(1) && characterController.activeLane != 1)
        {
            if (characterController.activeLane > 1)
                characterController.activeLane = 1;
            else
            {
                characterController.characterDirection += new Vector3(1, 0, 0);
                characterController.activeLane++;
            }
        }
        else if (Input.GetMouseButtonDown(0) && characterController.activeLane != -1)
        {
            if (characterController.activeLane < -1)
                characterController.activeLane = -1;
            else
            {
                characterController.characterDirection += new Vector3(-1, 0, 0);
                characterController.activeLane--;
            }

        }
    }
}
