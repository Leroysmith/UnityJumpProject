using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
	
	public bool isOnPlatform = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
		void FixedUpdate () {
		Vector3 snelheid = new Vector3();
		float runSpeed = 20f;
		float jumpSpeed = 20f;

		
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
			if(isOnPlatform == false)
			{
				snelheid.y = -15;
				rigidbody.velocity = snelheid;
			}
		}
		
		if (Input.GetKey(KeyCode.Space))
		{
			if(isOnPlatform == true)
			{
				isOnPlatform = false;
				snelheid.y = jumpSpeed;
				rigidbody.velocity = snelheid;
			}
		}
		
	}
	
	public void OnCollisionEnter(Collision col)
	{
		if (col.collider.gameObject.name == "Cube")
		{
		 isOnPlatform = true;	
		}
	}
	
	public void OnTriggerEnter(Collider col)
	{
		
		if (col.collider.gameObject.name == "Coin")
		{
			Destroy(col.gameObject);
		}
	
		if (col.collider.gameObject.name == "Destination")
		{
			Application.LoadLevel (0);
		}
}
}
