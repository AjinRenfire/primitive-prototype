using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Transform PlayerPosition;

    private float _speed = 40;
    private Rigidbody _enemyRb;

    // Start is called before the first frame update
    void Start()
    {
        PlayerPosition = GameObject.Find("Sphere").transform;
        _enemyRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direction = (PlayerPosition.position - transform.position).normalized;

        _enemyRb.AddForce(direction * _speed);
        

    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Bullet"))
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(collision.gameObject);
        }
    }
   
}
