using System;
using System.Collections.Generic;

namespace UnityEngine.XR.iOS
{
	public class UnityARGeneratePlaneAE : MonoBehaviour
	{
		public GameObject planePrefab;
        private UnityARAnchorManager unityARAnchorManager;
		private bool Hit = false; 

		// Use this for initialization
		void Start () {
			if (Hit == false) {
				unityARAnchorManager = new UnityARAnchorManager ();
				UnityARUtility.InitializePlanePrefab (planePrefab);
				Hit = true; 
			}
		}

        void OnDestroy()
        {
            unityARAnchorManager.Destroy ();
        }

        void OnGUI()
        {
            List<ARPlaneAnchorGameObject> arpags = unityARAnchorManager.GetCurrentPlaneAnchors ();
            if (arpags.Count >= 1) {
                //ARPlaneAnchor ap = arpags [0].planeAnchor;
                //GUI.Box (new Rect (100, 100, 800, 60), string.Format ("Center: x:{0}, y:{1}, z:{2}", ap.center.x, ap.center.y, ap.center.z));
                //GUI.Box(new Rect(100, 200, 800, 60), string.Format ("Extent: x:{0}, y:{1}, z:{2}", ap.extent.x, ap.extent.y, ap.extent.z));
            }
        }
	}
}

