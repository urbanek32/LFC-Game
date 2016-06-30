using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour
{

    public GameObject TargetToFollow;

	// Use this for initialization
	void Start () 
    {
	    
	}
	
	// Update is called once per frame
	void Update ()
	{
	    var newPosition = Vector3.Slerp(transform.position, TargetToFollow.transform.position, 2.0f);
	    newPosition.y = transform.position.y;
	    newPosition.z -= 4.5f;

	    transform.position = newPosition;
	}
}
