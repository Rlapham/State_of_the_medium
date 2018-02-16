using UnityEngine;
using System.Collections;

public class SpawnGlass : MonoBehaviour

{	
	public GameObject glass;
	public GameObject zone;

	int num = 50;
	float percent = 0.0f;

	private float colliderDelay = 0.2f; 
	private bool ColliderBool = false;



	// Instantiate the prefab somewhere between -10.0 and 10.0 on the x-z plane
	void Start()
	{
		for (int i = 0; i < num; i++) {

			Vector3 position = new Vector3 (Random.Range(transform.position.x - 1, transform.position.x + 1), Random.Range(transform.position.y - .5f, transform.position.y + .5f), Random.Range(transform.position.z-1, transform.position.z + 1));
			GameObject obj = (GameObject)Instantiate (glass, position, Quaternion.identity);
			int rot = Random.Range (0, 180);
			obj.transform.Rotate(0, rot, 0);

			obj.transform.parent = zone.transform;


			GameObject.Destroy (obj, 250f);
		
		}

	}

	void Update(){
//		if (ColliderBool == true) {
//			for (int i = 0; i < 5; i++) {
//
//				Vector3 position = new Vector3 (Random.Range(glass.transform.position.x - 2, glass.transform.position.x + 2), Random.Range(glass.transform.position.y - 2, glass.transform.position.y + 2), Random.Range(glass.transform.position.z-2, glass.transform.position.z + 2));
//				GameObject obj = (GameObject)Instantiate (glass, position, Quaternion.identity);
//				GameObject.Destroy (obj, 20f);
//			}
//			ColliderBool = false; 
//		}
	}

//	void orbSpawn1(){
//		Vector3 position = new Vector3(Random.Range(-3.1f, -3.5f), Random.Range(3.1f, 3.5f), Random.Range(3.1f, 3.5f));
//
////		Vector3 positionAttract = new Vector3(Random.Range(attractor.transform.position.x + 2.0f, attractor.transform.position.x + 3.0f), Random.Range(attractor.transform.position.y - 1.0f, attractor.transform.position.y + 1.0f), Random.Range(attractor.transform.position.z + 2.0f, attractor.transform.position.z + 3.0f));
//		GameObject obj = (GameObject)Instantiate (glass, position, Quaternion.identity);
//		GameObject.Destroy (obj, 40f);
//	}

//	void OnTriggerEnter (Collider other) {
//		if (ColliderBool == false) {
//			InvokeRepeating ("CollideTrue", colliderDelay, 0.0f);
//		}
//	}
//
//	void CollideTrue(){
//		ColliderBool = true; 
//	}
}
