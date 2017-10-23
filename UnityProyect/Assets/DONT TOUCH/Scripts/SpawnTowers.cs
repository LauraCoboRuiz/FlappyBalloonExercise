using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnTowers : MonoBehaviour
{
    public GameObject[] towers;
    public int index = 0;

    public float timeSpawn;
    public float timeCounter = 0;

    public float range;

	void Start ()
    {
        towers = new GameObject[transform.childCount];
        // Desactivar torres.
        for(int i = 0; i < towers.Length; i++)
        {
            towers[i] = transform.GetChild(i).gameObject;            
            towers[i].SetActive(false);            
        }
        for(int i = 0; i < towers.Length; i++) towers[i].transform.SetParent(null);

        timeCounter = timeSpawn;
    }
	
	// Update is called once per frame
	void Update ()
    {
        if(timeCounter >= timeSpawn)
        {
            timeCounter = 0;
            Spawn();
        }
        else timeCounter += Time.deltaTime;
	}

    void Spawn()
    {
        Vector3 spawnPosition = transform.position;
        spawnPosition.y = Random.Range(-range, range);

        towers[index].transform.position = spawnPosition;
        towers[index].SetActive(true);

        index++;
        if(index >= towers.Length) index = 0;
    }
}
