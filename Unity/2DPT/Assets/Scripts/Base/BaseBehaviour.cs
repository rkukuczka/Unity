using UnityEngine;
using System.Collections;

public class BaseBehaviour : MonoBehaviour
{
	
		// Update is called once per frame
		void Update ()
		{
				if (Input.GetKeyUp (KeyCode.Q)) {
						Application.LoadLevel (0);//start
				}
		}
	
}