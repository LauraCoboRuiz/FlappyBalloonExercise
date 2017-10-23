using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateTerrainPos : MonoBehaviour
{
    public Transform terrain;
    public Transform nextTerrain;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            nextTerrain.position = terrain.position + new Vector3(199.5f, 0, 0);
        }
    }
}
