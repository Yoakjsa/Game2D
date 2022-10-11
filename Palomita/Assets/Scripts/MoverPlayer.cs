using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverPlayer : MonoBehaviour
{
    
    public float forceJump;
    public Transform _initialPosition;

    Rigidbody _rigidbody;

    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>(); 
    }

    private void OnTriggerEnter(Collider other)
    {
      if (other.CompareTag("Danger"))
      {
        transform.position = _initialPosition.position;
      }

    if (Input.GetKeyDown(KeyCode.Space))
      {
        _rigidbody.AddForce(Vector3.up * forceJump, ForceMode.Impulse);
      }
     }
    
}

