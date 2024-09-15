using UnityEngine;
using System.Collections;

public class SpawnerScript : MonoBehaviour {

    public Transform prefab;
	
    private float nextObjTime = 0.0f;
    private float spawnRate = 1.5f;
	
	void Start(){
		
	}
 	
	void Update () {
				
        if (nextObjTime < Time.time)
        {
            SpawnTurtle();
            nextObjTime = Time.time + spawnRate;

            spawnRate *= 0.98f;
            spawnRate = Mathf.Clamp(spawnRate, 0.3f, 99f);
        }
	}

    void SpawnTurtle()
    {
        float addXPos = Random.Range(-1.6f, 1.6f);
        Vector3 spawnPos = transform.position + new Vector3(addXPos,0,0);
        Instantiate(prefab, spawnPos, Quaternion.Euler(270, 0, 0));
	}
	
}
