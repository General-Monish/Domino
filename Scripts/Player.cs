using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody rb;
    [SerializeField] private float Force;

    void Start()
    {
        rb = GetComponent<Rigidbody>(); // added 
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            rb.AddForce(0, 0, 1*Force, ForceMode.Impulse);
        }
    }
}
