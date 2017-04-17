using UnityEngine;
using System.Collections;

public class hole : MonoBehaviour {
	public GUIText loseText;
	public AudioSource audio;
	void OnTriggerEnter(Collider other)
	{

		if (other.gameObject.tag == "Player")
		{
			other.gameObject.SetActive(false);
			audio.Play();
			loseText.text="Game over!";
		}
	}
}
