using UnityEngine;
using System.Collections;

public class Player : LivingEntity {

    //variables for PlayerMove()
    public float velocity = 4.0f;
    public float moveHorizontal;
    public float moveVertical;

    private Vector3 _movement;

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
        _movement.Set(moveHorizontal, 0f, moveVertical);
        _movement = _movement.normalized * velocity * Time.deltaTime;
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
