using UnityEngine;
using System.Collections;

public class Player : LivingEntity {

    //variables for PlayerMove()
    public float velocity = 4.0f;
    public float moveHorizontal;
    public float moveVertical;

    private float xPos; //Player position on the x axis
    private float yPos; //Player position on the y axis

    //variables for PlayerJump()
    public bool hasJumped;
    public Rigidbody rigidBody;
    public float jumpSpeed = 6.0f;

    //variables for PlayerDeploysPlatform()

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void PlayerMove(float moveHorizontal, float moveVertical)
    {
        if (Input.GetAxis("Horizontal") < 0)
        {
            moveHorizontal = Input.GetAxis("Horizontal");
            xPos = transform.position.x;
            xPos = (xPos - moveHorizontal) * velocity * Time.deltaTime;
        }
        else if (Input.GetAxis("Horizontal") > 0)
        {
            moveHorizontal = Input.GetAxis("Horizontal");
            xPos = transform.position.x;
            xPos = (xPos - moveHorizontal) * velocity * Time.deltaTime;
        }
        else if (Input.GetAxis("Vertical") < 0)
        {
            moveVertical = Input.GetAxis("Vertical");
            yPos = transform.position.y;
            yPos = (yPos - moveVertical) * velocity * Time.deltaTime;
        }
        else if (Input.GetAxis("Vertical") > 0)
        {
            moveVertical = Input.GetAxis("Vertical");
            yPos = transform.position.y;
            yPos = (yPos + moveVertical) * velocity * Time.deltaTime;
        }
    }

    public void PlayerJump(bool hasJumped)
    {
        rigidBody = GetComponent<Rigidbody>();
        rigidBody.AddForce(transform.up * jumpSpeed, ForceMode.Impulse);//Based on the Unity description ForceMode.Impulse may look smoother. Try without if it doesn't look good.
    }

    public void UseTool()
    {
        //Leaving blank until we are ready to code Platformthrower.cs 
    }
}
