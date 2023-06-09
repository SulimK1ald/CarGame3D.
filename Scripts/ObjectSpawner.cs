﻿using UnityEngine;
using System.Collections;

public class ObjectSpawner : MonoBehaviour {

	
	public bool isSameDelay;
	public bool isRandomObject;
	public GameObject ObjectToSpwan;
	public GameObject[] ObjectsToSpwan;
	public float timeBeforSpawn;
	public float spawnDelay;
	public float MinDelay;
	public float MaxDelay;


	void Start () {
		if(isSameDelay)
		{
			InvokeRepeating("Spawn",timeBeforSpawn,spawnDelay);
		}
		else
		{
		StartCoroutine(Spawner());
		}
	}
	
	IEnumerator Spawner()
	{
		yield return new WaitForSeconds(Random.Range(MinDelay,MaxDelay));
		Spawn();
	}
	
	void Spawn () 
	{
		if(!isRandomObject){
		GameObject obj = Instantiate(ObjectToSpwan, transform.position, transform.rotation) as GameObject;
		}
		if(isRandomObject){
		GameObject obj = Instantiate(ObjectsToSpwan[Random.Range(0,ObjectsToSpwan.Length)],transform.position,transform.rotation) as GameObject;
		}
		if(!isSameDelay){
		StartCoroutine(Spawner());
		}
	}
}
