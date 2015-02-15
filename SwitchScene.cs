using UnityEngine;
using System.Collections;

public class SwitchScene : MonoBehaviour {
	void OnTriggerEnter(Collider other) {
		Application.LoadLevel("_Lose");
	}
}
