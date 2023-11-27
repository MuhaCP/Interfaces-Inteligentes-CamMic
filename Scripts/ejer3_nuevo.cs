using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejer3_nuevo : MonoBehaviour
{
    // Start is called before the first frame update
    int puntos = 0;
    public AudioSource audioSource;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter (Collision col)
    {
        if (col.gameObject.tag == "spider" && col.gameObject.transform.position.y < transform.position.y)
        {
            puntos += 10;
            Debug.Log("Puntos: " + puntos);
            audioSource.Play();
        }
    }
}
