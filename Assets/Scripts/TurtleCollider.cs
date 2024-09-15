using UnityEngine;
using System.Collections;

public class TurtleCollider : MonoBehaviour {

    PlayerScript myPlayerScript;

    void Awake()
    {
        myPlayerScript = GameObject.Find("Bucket").GetComponent<PlayerScript>();
    }

    //Triggered by Unity's Physics
	void OnTriggerEnter(Collider theCollision)
    {
        GameObject collisionGO = theCollision.gameObject;
        myPlayerScript.acertos++;
		GetComponent<AudioSource>().Play();
        Destroy(collisionGO);
    }
}
