using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour
{
    private Player _player;

	void Start ()
	{
	    _player = GetComponent<Player>();
	    if (_player == null)
	    {
	        Debug.LogError("Player not found");
	    }
	}
	
	void Update ()
	{
	    
	}

    void FixedUpdate()
    {
        UpdateMovement();
    }

    private void UpdateMovement()
    {
        var velocity = 150*GetMovementDirection()*Time.deltaTime;
        //transform.position += velocity;

        _player.GetComponentInChildren<Rigidbody>().AddForce(velocity);
    }

    private Vector3 GetMovementDirection()
    {
        var direction = Vector3.zero;
        //direction.y *= -1;  // invert the y-axis

        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            direction.x += 1;
        }

        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            direction.x -= 1;
        }

        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            direction.z += 1;

        }

        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            direction.z -= 1;
        }

        // Clamp the length of the vector to a maximum of 1.
        if (direction.sqrMagnitude > 1)
        {
            direction.Normalize();
        }

        return direction;
    }
}
