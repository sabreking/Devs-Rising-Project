using UnityEngine;
using System.Collections;

public class PlayerController : Player {

    Player _playerScriptRef = gameobject.GetComponent<Player>();
    // Use this for initialization
    void Start () {
       
        _playerScriptRef.hasJumped = false;
    }
	
	// Update is called once per frame
	void Update () {
	    if(Input.GetAxis("horizontal") != 0)
        {
           _playerScriptRef.PlayerMove(Input.GetAxis("Horizontal"),0F);
        }else if( Input.GetAxis("Vertical") != 0)
        {
            _playerScriptRef.PlayerMove(0F, Input.GetAxis("Vertical"));
        }else if (Input.GetAxis("Jump")!= 0){
            _playerScriptRef.PlayerJump(_playerScriptRef.hasJumped);
            _playerScriptRef.hasJumped = true;
        }else if (Input.GetAxis("Fire1") != 0)
        {
            _playerScriptRef.UseTool();
        }

	}
}
