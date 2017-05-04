using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class nextLvl : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter2D(Collision2D col){
		
		if (col.gameObject.tag.Equals( "Player")) {
			//Destroy (col.gameObject);
			Pause(5);
			Application.LoadLevel ("titol");
			//SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex);

		}
	}

	private IEnumerator Pause(int p){
		AudioSource music = GameObject.FindObjectOfType<AudioSource> ();
		Time.timeScale = 0.1f;
		music.Play();
		yield return new WaitForSeconds (p);
		Time.timeScale = 1;
	}
}
