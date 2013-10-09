using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
	
	bool isOnPlatform;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
		void FixedUpdate () {
		Vector3 snelheid = new Vector3();
		
		snelheid.y = rigidbody.velocity.y;
		
		if (Input.GetAxis("Horizontal") < 0)
		{
			snelheid.x = -10;
		}
		else if (Input.GetAxis("Horizontal") > 0)
		{
			snelheid.x = 10;
		}
		else
		{
			snelheid.x = 0;
		}
		
		if (Input.GetAxis("Jump") > 0 && isOnPlatform)
		{
			rigidbody.AddForce(new Vector3(0, 400, 0));
			isOnPlatform = false;
		}
		
		rigidbody.velocity = snelheid;
		
		if(transform.position.y < -8.5)
		{
			Application.LoadLevel (0);
		}
	}
}
