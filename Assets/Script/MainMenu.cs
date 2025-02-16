using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField] AudioMixer audioMixer;
    [SerializeField] AudioSource audioSource;
    public void SwitchScene (string  sceneName)
    {
        SceneManager.LoadScene (sceneName);
    }

    public void SetVolume (float volume)
    {
        float volumeInDecibels = -80 + 100 * volume; 
        Debug.Log("setting volume to:" + volume); 
        audioMixer.SetFloat("MusicVolume", volumeInDecibels);
    }
    //public void PlayClip(AudioClip clip)
    //{
    //    AudioSource.PlayOneShot(AudioClip);
    //    audioSource.loop = false;   
    //}
   
}
