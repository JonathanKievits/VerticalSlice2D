using UnityEngine;
using System.Collections;

public class PlayerRoar : MonoBehaviour
{
    [HideInInspector]
    public float currentCharge;

    private int regeneration;
    private int maxCharge;

    
	void Start ()
    {
        regeneration = 5;
        maxCharge = 100;
        currentCharge = 100;
        InvokeRepeating("Regenerate", 0.0f, 1.0f / regeneration);
	}
	
	void Update ()
    {
        if (currentCharge >= 99)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                currentCharge = 0;
            }
        }
	}

    void Regenerate()
    {
        if (currentCharge < maxCharge)
            currentCharge += 1;
    }

}
