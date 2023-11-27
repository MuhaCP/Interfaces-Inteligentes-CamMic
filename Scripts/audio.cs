using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Recorder : MonoBehaviour
{
    private AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = Microphone.Start(Microphone.devices[2], true, 10, 44100);

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {   
            Debug.Log("Play");
            Microphone.End(Microphone.devices[2]);
            audioSource.Play();
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {   
            Debug.Log("Stop");
            audioSource.clip = Microphone.Start(Microphone.devices[2], true, 10, 44100);
        }
    }
}
