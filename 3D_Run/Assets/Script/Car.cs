using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    Rigidbody rb;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Vector3 carPos = new Vector3(0, 3, 15);

            rb = gameObject.GetComponent<Rigidbody>();

            rb.AddForce(carPos * 2f , ForceMode.Impulse);
            rb.AddTorque(Vector3.up * 15, ForceMode.Impulse);

            Destroy(gameObject, 5f);
        }

    }
}
