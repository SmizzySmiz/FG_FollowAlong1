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

    public void Awake()
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

    
 }

