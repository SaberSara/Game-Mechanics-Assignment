using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{

    [SerializeField] private float movementSpeed;
    [SerializeField] private float smoothTime;
    [SerializeField] private Animator characterAnimator;
    
    [Header("Debug Only")] [SerializeField]
    Vector3 currentVeclocity;

    [SerializeField] public int activeLane;

    public Vector3 characterDirection;

    void Start()
    {
        characterDirection = transform.position;

    }

    void Update()
    {
        characterDirection += new Vector3(0, 0, movementSpeed * Time.deltaTime);
        transform.position = transform.position = Vector3.SmoothDamp(transform.position, characterDirection, ref currentVeclocity, smoothTime);
        characterAnimator.SetInteger("direction",(int)characterDirection.x);
        characterAnimator.SetFloat("speed",characterDirection.z);
    }
}
