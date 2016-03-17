using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{
    Player _curPlayer;

    // Use this for initialization
    void Start ()
    {
        _curPlayer = GetComponent<Player> ();
    }

    // Update is called once per frame
    void Update ()
    {

    }

    public void FixedUpdate ()
    {
        _curPlayer.PlayerMove (Input.GetAxis ("Horizontal") , Input.GetAxis ("Vertical"));
    }
}
