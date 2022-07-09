using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DurdurmaKod : MonoBehaviour
{
    public GameObject DurdurmaPaneli;
    public bool oyundurdumu = false;

    public void Durdurma()
    {
        if (!oyundurdumu)
        {
            DurdurmaPaneli.SetActive(true);
            oyundurdumu = true;
            Time.timeScale = 0f;
        }
        else
        {
            DurdurmaPaneli.SetActive(false);
            oyundurdumu = false;
            Time.timeScale = 1f;
        }
    }
}
