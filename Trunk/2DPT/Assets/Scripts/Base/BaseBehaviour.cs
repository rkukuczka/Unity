using UnityEngine;
using System.Collections;

public class LevelChanger : MonoBehaviour {
	

	// Update is called once per frame
	void Update () {
		if(Input.GetKeyUp(KeyCode.Q))
		{
			Application.loadedLevel(0);//start
		}
	
}