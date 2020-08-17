using System.Collections;
using System.Collections.Generic;
using System.Xml.Schema;
using UnityEngine;

public class PlayRandomSound : MonoBehaviour
{
    AudioSource myAudioSource;

    [SerializeField]
    AudioClip fire;
    bool fireActive = true;

    [SerializeField]
    AudioClip water;
    bool waterActive = true;

    [SerializeField]
    AudioClip electricity;
    bool electricityActive = true;


    void Start()
    {
        myAudioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        
    }

    public void RandomSound()
    {
        List<AudioClip> audioClips = new List<AudioClip>();
        if (fireActive) {
            audioClips.Add(fire);
        }
        if (waterActive) {
            audioClips.Add(water);
        }
        if (electricityActive) {
            audioClips.Add(electricity);
        }
        myAudioSource.PlayOneShot(audioClips[Random.Range(0, audioClips.Count)]);
    }

    public void ToggleFireActive(bool value)
    {
        fireActive = value;
    }
    public void ToggleWaterActive(bool value)
    {
        waterActive = value;
    }
    public void ToggleElectricityActive(bool value)
    {
        electricityActive = value;
    }

}
