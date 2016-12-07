using UnityEngine;
using System.Collections;

public class PlayerRoar : MonoBehaviour
{
    [HideInInspector]
    public float currentCharge;

    private int regeneration = 5;
    private int maxCharge = 100;

    
	// Use this for initialization
	void Start ()
    {
        currentCharge = 100;
        InvokeRepeating("Regenerate", 0.0f, 1.0f / regeneration);
	}
	
	// Update isc called once per frame
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            currentCharge = 0;
        }

        Debug.Log(currentCharge);
	
	}

    void Regenerate()
    {
        if (currentCharge < maxCharge)
            currentCharge += 1;
    }

}
