using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundEffects : MonoBehaviour
{
    [SerializeField] private AudioSource audioSource;
    [SerializeField] private AudioClip jumpingFX;

    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    public void PlayJumpSound()
    {
        audioSource.PlayOneShot(jumpingFX);
    }
}