using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float Speed;

    private Rigidbody _playerRb; //rb is rigidbody
    // Start is called before the first frame update
    void Start()
    {
        _playerRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        _playerRb.AddForce(Vector3.right * Speed * Input.GetAxis("Horizontal"));
        _playerRb.AddForce(Vector3.forward * Speed * Input.GetAxis("Vertical"));

    }
}
