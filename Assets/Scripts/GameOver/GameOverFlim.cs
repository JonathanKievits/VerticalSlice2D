using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class GameOverFlim : MonoBehaviour 
{
    [SerializeField]
    private Texture movie;
    [SerializeField]
    private RawImage display;
  

    // Use this for initialization
    void Start ()
    {


        MovieTexture easterEgg = (MovieTexture)movie;
        display.texture = easterEgg;
        easterEgg.Play();
        easterEgg.loop = false;
        

    }

    // Update is called once per frame
    void Update ()
    {

    }
}
