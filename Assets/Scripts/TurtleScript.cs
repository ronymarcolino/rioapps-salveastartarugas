using UnityEngine;
using System.Collections;

public class TurtleScript : MonoBehaviour {
	
	PlayerScript myPlayerScript;

    void Awake()
    {
         //
         myPlayerScript = GameObject.Find("Bucket").GetComponent<PlayerScript>();
    }

    //Update is called by Unity every frame
	void Update () {
				
        float fallSpeed = 2 * Time.deltaTime;
        transform.position -= new Vector3(0, fallSpeed, 0);

        if (transform.position.y < -2)// 
        {
            myPlayerScript.erros++;
            Destroy(gameObject);
        }

         if (transform.position.y >= 20)// 
        {
            Destroy(gameObject);
        }
	}
}
