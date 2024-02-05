using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class movement : MonoBehaviour
{
   // float x, y;

  [SerializeField]  public float Speed;
    private Vector2 MoveInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        //x = Input.GetAxisRaw("Horizontal");
        //transform.Translate(new Vector3(1, 0, 0) * x * Speed*Time.deltaTime);

        //y = Input.GetAxis("Vertical");
        //transform.Translate(new Vector3(0, 0, 1) * y * Speed * Time.deltaTime);

        Vector3 moveDir = new Vector3(MoveInput.x, 0f, MoveInput.y);
        transform.position += moveDir*Speed*Time.deltaTime;
    }

    private Vector2 Move()
    {
         MoveInput = new Vector2(0, 0);
        if (Input.GetKey(KeyCode.W))
        {
            
            MoveInput.y = +1;
        } 
        if (Input.GetKey(KeyCode.S))
        {
            
            MoveInput.y = -1;
        }
        if (Input.GetKey(KeyCode.A))
        {
            
            MoveInput.x = -1;
        } 
        if (Input.GetKey(KeyCode.D))
        {
           
            MoveInput.x = +1;
        }
        MoveInput = MoveInput.normalized;
        return MoveInput;
    }
}
