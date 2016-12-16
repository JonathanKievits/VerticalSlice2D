using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class GameOver : MonoBehaviour {

    AudioSource death;
    

	// Use this for initialization
	void Start()
    {
        death = GetComponent<AudioSource>();
        death.Play();
    }
    
	
	
	// Update is called once per frame
	void Update ()
    {
        if (!death.isPlaying)
        {
            SceneManager.LoadScene(0);
        }

       
	}
}
