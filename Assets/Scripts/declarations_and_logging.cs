using UnityEngine;
using System.Collections;

public class declarations_and_logging : MonoBehaviour {

	int myInt = 5;
	int val;

	void Start () {
		val = MultiplyByTwo (myInt);
		Debug.Log (val);
	}

	int MultiplyByTwo(int number) {
		int val;
		val = number * 2;

		return val;
	}
}
