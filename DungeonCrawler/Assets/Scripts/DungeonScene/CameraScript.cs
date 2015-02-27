using UnityEngine;
using System.Collections;

public class CameraScript : MonoBehaviour {

	public float camSpeed;
	float leftBorder,rightBorder;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position.x < rightBorder) {
			transform.position = new Vector3 (transform.position.x + camSpeed*Time.deltaTime, transform.position.y, transform.position.z);
		}
	}

	public void setBorders(int size){
		leftBorder = 0;
		rightBorder = (size - 1) * 17.8f;
	}
}
