using UnityEngine;
using System.Collections;

public class AwakeAndStart : MonoBehaviour {

	void Awake () {
		print ("I've been intialized, but nothing has happend yet. I might not even be enabled!");
	}

	void Start () {
		print ("I'm enabled, and ready to do things!");
	}
}
