using UnityEngine;
using System.Collections;

public class Player : LivingEntity {

    //variables for PlayerMove()
    float velocity = 0.3f;

    //variables for PlayerJump()
    bool hasJumped;
    Rigidbody rigidBody;
    float jumpSpeed = 6.0f;

    //variables for UseTool()

    // Use this for initialization
    public override void Start () {
        base.Start ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void PlayerMove(float moveHorizontal, float moveVertical)
    {
        if ( moveHorizontal < 0)
        {
            var xPos = transform.position.x+velocity*-1;
            
            transform.position= new Vector3 (xPos , transform.position.y , transform.position.z);
        }
        else if ( moveHorizontal > 0)
        {
            var xPos = transform.position.x + velocity;

            transform.position = new Vector3 (xPos , transform.position.y , transform.position.z);
        }
    }

    public void PlayerJump(bool hasJumped)
    {
        if (hasJumped == true)
        {
            rigidBody = GetComponent<Rigidbody>();
            rigidBody.AddForce(transform.up * jumpSpeed, ForceMode.Impulse);//Based on the Unity description ForceMode.Impulse may look smoother. Try without if it doesn't look good.
        }
    }

    public void UseTool()
    {
        //Leaving blank until we are ready to code Platformthrower.cs 
    }
}
