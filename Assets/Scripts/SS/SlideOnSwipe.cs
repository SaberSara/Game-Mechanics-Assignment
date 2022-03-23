using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(CharacterController))]
public class SlideOnSwipe : MonoBehaviour
{
    
      private CharacterController characterController;

      private void Start()
      {
          characterController = GetComponent<CharacterController>();
      }

      void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            
            MoveLane(-1);
            
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            MoveLane(1);
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
