using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoverScript : MonoBehaviour
{
	public AudioSource Sound;
    
	private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Swimmer")
        {
            print("Hover collided with " + other.gameObject.tag + " other");
            other.gameObject.GetComponent<SwimmerGlowScript>().TurnOnGlow();
			//gameObject.GetComponent<AudioSource>().Play();
			Sound.Play();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Swimmer")
        {
            print("Hover STOPPED colliding with " + other.gameObject.tag);
            other.gameObject.GetComponent<SwimmerGlowScript>().TurnOffGlow();
			//gameObject.GetComponent<AudioSource>().Stop();
			Sound.Stop();
        }
    }
}
