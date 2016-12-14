using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class RoarBar : MonoBehaviour
{
    [SerializeField]
    private GameObject playert;
    [SerializeField]
    private Slider slidert;

    private PlayerRoar playerRoar;

	// Use this for initialization
	void Start ()
    {
        playerRoar = playert.GetComponent<PlayerRoar>();	
	}
	
	// Update is called once per frame
	void Update ()
    {
        slidert.value = (playerRoar.currentCharge - 0) / (100 - 0);
	}
}
