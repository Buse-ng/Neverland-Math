using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Silme : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D sil)
    {
        //string objeAd = sil.gameObject.name;
        if (sil.gameObject.tag=="obje")
        {
            Destroy(sil.gameObject);
        }
    }
}