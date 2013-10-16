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
		float jumpSpeed = 40f;
		float runSpeed = 20f;
		
		
		snelheid.y = rigidbody.velocity.y;
		
		if (Input.GetAxis("Horizontal") < 0)
		{
			snelheid.x = -runSpeed;
			rigidbody.velocity = snelheid;
		}
		else if (Input.GetAxis("Horizontal") > 0)
		{
			snelheid.x = runSpeed;
			rigidbody.velocity = snelheid;
		}
		else
		{
			snelheid.x = 0;
		}
		
		
		if (Input.GetAxis("Jump") > 0)
		{
			transform.position += transform.up * jumpSpeed * Time.deltaTime;
		}
		

		
	
		
		if(transform.position.y < -800)
		{
			Application.LoadLevel (0);
		}
	}
}
