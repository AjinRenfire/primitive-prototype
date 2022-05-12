using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform PlayerTransform;

    [SerializeField]private Vector3 _offsetPosition ;



    private void Update()
    {
       
    }

    void FixedUpdate()
    {
        transform.position = PlayerTransform.position + _offsetPosition;
        
    }

   
}
