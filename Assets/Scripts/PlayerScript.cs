using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour {
    
    public int acertos = 0;
    public int erros = 0;
	
	void Update () {
        float moveInput = Input.GetAxis("Vertical") * Time.deltaTime * 3; 
        transform.position += new Vector3(moveInput, 0, 0);

        if (transform.position.x <= -2.5f || transform.position.x >= 2.5f)
        {
            float xPos = Mathf.Clamp(transform.position.x, -2.5f, 2.5f);
            transform.position = new Vector3(xPos, transform.position.y, transform.position.z);
        }
	}

}
