using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

public class Music : MonoBehaviour
{
    public static Music instance;
    [SerializeField] private AudioSource musicSource;
    public bool Always = true;
    public GameObject music;

    public void Awake() // Play BG Music, does not play on top of itself
    {
        if (instance == null)
        {
            DontDestroyOnLoad(this.gameObject);
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(this.gameObject);
        }
    }

    //Does not work as intended - search for solutions
    /*public void EndGame()
    {
        if(GetComponent<GameOverMenu>())
        {
            Destroy(this.gameObject);
        }        
    }*/

    
 }

