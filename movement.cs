using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class movement : MonoBehaviour
{
    float x, y;

   public float Speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        x = Input.GetAxisRaw("Horizontal");
        transform.Translate(new Vector3(1, 0, 0) * x * Speed*Time.deltaTime);
    
        y = Input.GetAxis("Vertical");
        transform.Translate(new Vector3(0, 0, 1) * y * Speed * Time.deltaTime);
    }
}
