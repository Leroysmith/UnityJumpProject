using UnityEngine;
using System.Collections;

public class CameraScript : MonoBehaviour {
	public Transform target;
	public float distance = 10;
	
	// Use this for initialization
	
	// Update is called once per frame
	void Update () 
	{
		Vector3 temp = transform.position;
		//.position.z = target.position.z -distance;
		temp.z = target.position.z - distance;
		temp.x = target.position.x;
		temp.y = target.position.y;
		transform.position = temp;
	}
}
