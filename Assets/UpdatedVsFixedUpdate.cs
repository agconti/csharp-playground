using UnityEngine;
using System.Collections;

public class UpdateAndFixedUpdate : MonoBehaviour
{
	/* Called at a regular interval independent of framerate. All physicis 
	 * calculations should be done here. 
	 */
	void FixedUpdate ()
	{
		Debug.Log("FixedUpdate time :" + Time.deltaTime);
	}
	

	/* called once per frame. Frames will take diffrent times to process depending on
	 * what needs to be rendered in that frame. The result is that this print statement 
	 * will log at irregular intervals.
	 */
	void Update ()
	{
		Debug.Log("Update time :" + Time.deltaTime);
	}
}