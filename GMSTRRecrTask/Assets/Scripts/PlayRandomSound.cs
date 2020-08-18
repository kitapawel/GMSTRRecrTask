using System.Collections;
using System.Collections.Generic;
using System.Xml.Schema;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PlayRandomSound : MonoBehaviour
{
    AudioSource myAudioSource;
    TextMeshProUGUI textMeshPro;


    [SerializeField]
    AudioClip fire;
    [SerializeField]
    Toggle fireToggle;
    
    [SerializeField]
    AudioClip water;
    [SerializeField]
    Toggle waterToggle;

    [SerializeField]
    AudioClip electricity;
    [SerializeField]
    Toggle electricityToggle;

    void Start()
    {
        myAudioSource = GetComponent<AudioSource>();
        textMeshPro = GetComponentInChildren<TextMeshProUGUI>();
        textMeshPro.text = "Press to play random sound";
    }

    public void RandomSound()
    {
        List<AudioClip> audioClips = new List<AudioClip>();
        if (fireToggle.isOn) {
            audioClips.Add(fire);
        }
        if (waterToggle.isOn) {
            audioClips.Add(water);
        }
        if (electricityToggle.isOn) {
            audioClips.Add(electricity);
        }

        if (audioClips.Count == 0)
        {
            StartCoroutine(NoSoundsChosenWarning());
        } else
        {
            textMeshPro.text = "Press to play random sound";
            myAudioSource.PlayOneShot(audioClips[Random.Range(0, audioClips.Count)]);
        }

    }

    IEnumerator NoSoundsChosenWarning()
    {
        textMeshPro.text = "No sounds selected";
        yield return new WaitForSeconds(2f);
        textMeshPro.text = "Press to play random sound";
    }

}
