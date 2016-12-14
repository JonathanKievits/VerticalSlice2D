using UnityEngine;
using System.Collections;

public class Following : MonoBehaviour {

    [SerializeField]
    private Transform player;

	void Update ()
    {
        this.transform.position = player.position;
	}
}
