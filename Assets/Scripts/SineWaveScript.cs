using UnityEngine;
using System.Collections;

public class SineWaveScript : MonoBehaviour {

	void Start () {
	
	}
	
	public float amplitudeX = 10.0f;
	public float amplitudeY = 5.0f;
	public float omegaX = 1.0f;
	public float omegaY = 5.0f;
	public float index;
	
	public float pos_x;
	public float pos_y;
 
	public void Update(){
	    index += Time.deltaTime;
	    float x = pos_x + amplitudeX*Mathf.Cos (omegaX*index);
	    float y = pos_y + Mathf.Abs (amplitudeY*Mathf.Sin (omegaY*index));
	    transform.localPosition = new Vector3(x,y,-6.0f);
	}
}
