using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //PUBLIC VARIABLES
    public float speed = 10.0f;
    public float jumpForce = 500;


    //PRIVATE VARIABLES
    private Rigidbody2D rBody;

    // Reserved function. Run only once when the object is /// <summary>
    // User for initialization.
    void Start(){
        rBody = GetComponent<Rigidbody2D>();

    }
    void Update(){
        if(Input.GetKeyDown(KeyCode.Space))
        {
            rBody.AddForce(new Vector2(0,jumpForce));
            
        }
    }

    ///<summary>
    /// This function is called every framerate frame, if the monobehaviour is private void OnFailedToConnect(NetworkConnectionError error) {
    /// Use FixedUpdate for Physics-based movement only.!--
    ///</summary>
    
    void FixedUpdate(){
        float horiz = Input.GetAxis("Horizontal");
        rBody.velocity = new Vector2(horiz*speed, rBody.velocity.y);
        // float vert = Input.GetAxis("vertical");

        
    }
}
