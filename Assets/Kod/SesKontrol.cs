using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SesKontrol : MonoBehaviour
{
    public AudioClip ziplama;
    AudioSource ses;
    void Start()
    {
        ses = GetComponent<AudioSource>();

    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.X)) // X tu�una bas�nca calan ses dursun
        {
            ses.Pause();
        }
        if (Input.GetKeyDown(KeyCode.O)) // O tu�una bas�nca calan ses baslasin
        {
            ses.Play();
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            ses.PlayOneShot(ziplama, 0.7f);
        }
    }
}
