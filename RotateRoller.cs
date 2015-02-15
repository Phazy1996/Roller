using UnityEngine;
using System.Collections;

public class RotateRoller : MonoBehaviour {
	public float speed;

	void Update() {
		transform.Rotate(Vector3.up * Time.deltaTime * speed);
		transform.Rotate(Vector3.right * Time.deltaTime * speed, Space.World);
	}
}
