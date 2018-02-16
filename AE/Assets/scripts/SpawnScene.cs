using UnityEngine;
using System.Collections;

public class SpawnScene : MonoBehaviour

{	
	public GameObject scene;

	// Instantiate the prefab somewhere between -10.0 and 10.0 on the x-z plane
	void Start()
	{
		
		Vector3 position = new Vector3 (0, -1, -1);
			GameObject obj = (GameObject)Instantiate (scene, position, Quaternion.identity);

//			GameObject.Destroy (obj, 250f);

	}

	void Update(){

	}
		
}
