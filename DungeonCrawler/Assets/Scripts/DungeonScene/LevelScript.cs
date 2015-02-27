using UnityEngine;
using System.Collections;

public class LevelScript : MonoBehaviour {

	public Camera cam;
	public GameObject background;

	int levelsize;
	GameObject[] backgrounds;
	public Sprite[] sprites = new Sprite[6];
	// Use this for initialization
	void Start () {
		levelsize = Random.Range (5,10);
		backgrounds = new GameObject[levelsize];
		genLevel ();
		cam.GetComponent<CameraScript>().setBorders(levelsize);

	}
	
	// Update is called once per frame
	void Update () {
	
	}


	void genLevel(){
		Debug.Log ("Levelsize: " + levelsize);
		Vector3 pos = new Vector3(cam.transform.position.x, cam.transform.position.y, 0);
		backgrounds[0] = (GameObject) Instantiate(background, pos, Quaternion.identity);
		pos = new Vector3(cam.transform.position.x + (levelsize-1)*17.8f, cam.transform.position.y, 0);
		backgrounds[levelsize-1] = (GameObject) Instantiate(background, pos, Quaternion.identity);

		for(int i = 1; i < levelsize-1; i++){
			pos = new Vector3(cam.transform.position.x + i*17.8f, cam.transform.position.y, 0);
			backgrounds[i] = (GameObject) Instantiate(background, pos, Quaternion.identity);
			backgrounds[i].GetComponent<SpriteRenderer>().sprite = sprites[Random.Range(0,5)];
			
		}


	}
}
