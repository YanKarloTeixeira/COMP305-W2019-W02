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
    private Animator anim;
    private bool isFacingRight=true;

    // Reserved function. Run only once when the object is /// <summary>
    // User for initialization.
    void Start(){
        rBody = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();

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
        // check direction of the private void OnPlayerConnected(NetworkPlayer player) {
            if(horiz<0 && isFacingRight)
            {
                Flip();
            } else if (horiz > 0 && !isFacingRight){
                Flip();
            }
        
        //update animator information
        anim.SetFloat("Speed",Mathf.Abs(horiz));
    }

    public void Flip()
    {
        isFacingRight = !isFacingRight;
        Vector2 temp = transform.localScale;
        temp.x *= -1;
        transform.localScale = temp;
    }
}
