using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    [SerializeField] Rigidbody2D rb;
    [SerializeField] float speed = 3.1f;
    
 
    float horizontalInput;
    float verticalInput;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        Debug.Log("h " + horizontalInput + "     v " + verticalInput);
    }
    // Update is called once per frame
    void FixedUpdate()
    {


        Vector2 movement = new Vector2(horizontalInput, verticalInput) * speed * Time.fixedDeltaTime;
        rb.AddRelativeForce(movement);
    }


}
