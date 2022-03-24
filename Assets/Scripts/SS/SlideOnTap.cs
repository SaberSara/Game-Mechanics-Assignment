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
        if (Input.GetMouseButtonDown(1))
        {
            MoveLane(1);
        }
        else if (Input.GetMouseButtonDown(0))
        {
            MoveLane(-1);
        }
    }
    
    private void MoveLane(int direction)
    {
        if (characterController.activeLane != direction)
        {
            characterController.characterDirection += new Vector3(direction, 0, 0);
            characterController.activeLane+=direction;
        }
    }
}
