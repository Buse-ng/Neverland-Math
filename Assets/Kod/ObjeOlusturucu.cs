using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjeOlusturucu : MonoBehaviour
{
    public GameObject kaktus, engel2, para, kalp, ari;
    float olusturmaSuresi = 3f; // kac saniyede olusacaklari
    float zamanSayaci = 0f;
    void Update()
    {
        zamanSayaci -= Time.deltaTime;
        if (zamanSayaci < 0 && !(KarakterKontrol.puanSayac>=60))
        {
            Olusturucu();
            zamanSayaci = olusturmaSuresi;
        }
    }
    public void Olusturucu()
    {
        int secim=Random.Range(1,7);//bunu 1 yapmam lazým yoksa hep para kalp gelir
        int canSec = Random.Range(1,3);//bunu 1 yapmam lazým yoksa hep  kalp gelir
        switch (secim)
        {

            case 1:// instenþeyt
                GameObject go_kaktus = Instantiate(kaktus, new Vector3(9.2f, -3.0f, 0), Quaternion.Euler(0, 0, 0)) as GameObject; //instantiate: belirli bi konumda bir sey olusturmak icin
                //go_kaktus.GetComponent<Rigidbody2D>().AddForce(new Vector3(-80f, 0, 0)); // fizigini secip kuvvet olusturduk sola gitsin diye
                break;
            case 2: 
                GameObject go_ari = Instantiate(ari, new Vector3(9.2f, Random.Range(-2.2f,-3.0f), 0), Quaternion.Euler(0, 0, 0)) as GameObject;
                //go_ari.GetComponent<Rigidbody2D>().AddForce(new Vector3(-80f, 0, 0));  //1.7-> -2.2
                break;
            case 3: // engel ve para ayni anda gelirken
                float temp=Random.Range(-3.0f,-2.5f); // -3  ,  0.9
                GameObject go_engel = Instantiate(engel2, new Vector3(9.2f, temp, 0), Quaternion.Euler(0, 0, 0)) as GameObject;
                //go_engel.GetComponent<Rigidbody2D>().AddForce(new Vector3(-80f, 0, 0));

                GameObject go_para = Instantiate(para, new Vector3(9.2f,temp+0.7f, 0), Quaternion.Euler(0, 0, 0)) as GameObject;
                //go_para.GetComponent<Rigidbody2D>().AddForce(new Vector3(-80f, 0, 0));
                break;
            case 4://
                GameObject go_engel2 = Instantiate(engel2, new Vector3(9.2f, Random.Range(-3.0f, -2.5f), 0), Quaternion.Euler(0, 0, 0)) as GameObject;
                //go_engel2.GetComponent<Rigidbody2D>().AddForce(new Vector3(-80f, 0, 0));
                break;

            case 5:
                GameObject go_para2 = Instantiate(para, new Vector3(9.2f, Random.Range(-3.2f, -0.65f), 0), Quaternion.Euler(0, 0, 0)) as GameObject;
                //go_para2.GetComponent<Rigidbody2D>().AddForce(new Vector3(-80f, 0, 0));
                break;
            case 6:
                    GameObject go_kalp = Instantiate(kalp, new Vector3(9.2f, Random.Range(-1.7f, -0.9f), 0), Quaternion.Euler(0, 0, 0)) as GameObject;
                    go_kalp.GetComponent<Rigidbody2D>().AddForce(new Vector3(-80f, 0, 0));    // 0.6 -> -0.9
                    break;
                /*
                if (canSec == 1)
                {
                    GameObject go_kalp = Instantiate(kalp, new Vector3(9.2f, Random.Range(-1.7f, -0.9f), 0), Quaternion.Euler(0, 0, 0)) as GameObject;
                    go_kalp.GetComponent<Rigidbody2D>().AddForce(new Vector3(-80f, 0, 0));    // 0.6 -> -0.9
                }
                else if( canSec==2)
                {
                    GameObject go_para3 = Instantiate(para, new Vector3(9.2f, Random.Range(-3.2f, -0.65f), 0), Quaternion.Euler(0, 0, 0)) as GameObject;
                    //go_para3.GetComponent<Rigidbody2D>().AddForce(new Vector3(-80f, 0, 0));
                }
                break;*/
        }        
    }
}