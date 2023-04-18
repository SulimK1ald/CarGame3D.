using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class EnemyBox : MonoBehaviour {
	void Start () {
	
	}
	
	void OnTriggerEnter(Collider boxCollider)
	{
		if(boxCollider.name == "Car")
		{
			SceneManager.LoadScene("lesson7");
		}
	}
}
