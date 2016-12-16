using UnityEngine;
using System.Collections;

public class PlayerRoar : MonoBehaviour
{
    [HideInInspector]
    public float currentCharge;
    [HideInInspector]
    public bool roaring;

    private int regeneration;
    private int maxCharge;
   
    
	void Start ()
    {
        roaring = false;
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
                StartCoroutine("RoarAniWait");
                roaring = true;
                currentCharge = 0;
            }
        }
	}

    void Regenerate()
    {
        if (currentCharge < maxCharge)
            currentCharge += 1;
    }

    IEnumerator RoarAniWait()
    {
        yield return new WaitForSeconds(0.75f);
        roaring = false;
        StopCoroutine("RoarAniWait");
    }

}
