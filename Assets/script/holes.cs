using UnityEngine;
using System.Collections;

public class holes : MonoBehaviour {

	public GUIText winText;
	public AudioSource audio;
	void OnTriggerEnter(Collider other)
	{
		
		if (other.gameObject.tag == "Player")
		{
			other.gameObject.SetActive(false);
			audio.Play();
			winText.text="You win!";
		}
	}
}
