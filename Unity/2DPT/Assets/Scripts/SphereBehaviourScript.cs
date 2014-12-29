using UnityEngine;
using System.Collections;

public class SphereBehaviourScript : MonoBehaviour {

	public Transform target;
	public float speed=0.10f;
	void Update() {
		//float step = speed * Time.deltaTime;
		//transform.position = Vector3.MoveTowards(transform.position, target.position, step);
	}
}
