using UnityEngine;
using System.Collections;

public class SphereScript : MonoBehaviour {
	
	private float initial;
	private GameObject _debugPointer;
	// Use this for initialization
	void Start () {
		initial = this.transform.position.y;
		SetGazedAt (false);
	}
	
	// Update is called once per frame
	void Update () {
		Bounce();
		this.transform.Rotate (Vector3.up, Random.value * 2);
		if (this.GetComponent<AudioSource> ().isPlaying) {
			this.GetComponent<Light> ().intensity = 15;
		} else {
			this.GetComponent<Light>().intensity = 2.5f;
		}
	}

	//Bounce lightly to gain attention
	void Bounce()
	{
		float distance = .2f;
		float speed = 1.0f;
		float yBounce = initial + Mathf.Sin (Time.time * speed) * distance / 2.0f;
		this.transform.position = new Vector3 (this.transform.position.x,
		                                       yBounce,
		                                       this.transform.position.z);

	}

	public void SetGazedAt(bool gazedAt) {
		if (gazedAt) {
			Debug.Log ("Entered Gaze on " + this.gameObject.tag);
			GetComponent<AudioSource> ().Play ();
            GetComponent<ParticleSystem>().Play();
		}

		//GetComponent<Renderer>().material.color = gazedAt ? Color.green : Color.red;
	}

    public void OnSelect()
    {
        SetGazedAt(true);
    }
}
