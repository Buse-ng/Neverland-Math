using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TemassızObjeler : MonoBehaviour
{
    public GameObject yesil, mor, turuncu, pembe;
    //public GameObject yildiz1,yildiz2,yildiz3,yildiz4;
    float olusturmaSuresi = 4f; // kac saniyede olusacaklari
    float zamanSayaci = 0f;
    void Update()
    {
        zamanSayaci -= Time.deltaTime;
        if (zamanSayaci < 0)
        {
            bulutOlusturma();
            //yildizOlusturma();
            zamanSayaci = olusturmaSuresi;
        }
    }
    public void bulutOlusturma()
    {
        int sec = Random.Range(1, 5);
        switch (sec)
        {
            case 1:
                GameObject bulut_yesil = Instantiate(yesil, new Vector3(9.7f, 3.1f, 0), Quaternion.Euler(0, 0, 0)) as GameObject; //instantiate: belirli bi konumda bir sey olusturmak icin
                bulut_yesil.GetComponent<Rigidbody2D>().AddForce(new Vector3(-80f, 0, 0)); 
                break;
            case 2:
                GameObject bulut_mor = Instantiate(mor, new Vector3(9.7f, 2.7f, 0), Quaternion.Euler(0, 0, 0)) as GameObject; //instantiate: belirli bi konumda bir sey olusturmak icin
                bulut_mor.GetComponent<Rigidbody2D>().AddForce(new Vector3(-80f, 0, 0));
                break;
            case 3:
                GameObject bulut_turuncu = Instantiate(turuncu, new Vector3(9.7f, 3.3f, 0), Quaternion.Euler(0, 0, 0)) as GameObject; //instantiate: belirli bi konumda bir sey olusturmak icin
                bulut_turuncu.GetComponent<Rigidbody2D>().AddForce(new Vector3(-80f, 0, 0));
                break;
            case 4:
                GameObject bulut_pembe = Instantiate(pembe, new Vector3(9.7f, 2.9f, 0), Quaternion.Euler(0, 0, 0)) as GameObject; //instantiate: belirli bi konumda bir sey olusturmak icin
                bulut_pembe.GetComponent<Rigidbody2D>().AddForce(new Vector3(-80f, 0, 0));
                break;
        }
    }
    /*public void yildizOlusturma()
    {
        int secim = Random.Range(1, 5);
        switch (secim)
        {
            case 1:
                GameObject obj_yildiz1 = Instantiate(yildiz1, new Vector3(9.7f, 3.1f, 0), Quaternion.Euler(0, 0, 0)) as GameObject; //instantiate: belirli bi konumda bir sey olusturmak icin
                obj_yildiz1.GetComponent<Rigidbody2D>().AddForce(new Vector3(-80f, 0, 0));
                break;
            case 2:
                GameObject obj_yildiz2 = Instantiate(yildiz2, new Vector3(9.7f, 2.7f, 0), Quaternion.Euler(0, 0, 0)) as GameObject; //instantiate: belirli bi konumda bir sey olusturmak icin
                obj_yildiz2.GetComponent<Rigidbody2D>().AddForce(new Vector3(-80f, 0, 0));
                break;
            case 3:
                GameObject obj_yildiz3 = Instantiate(yildiz3, new Vector3(9.7f, 3.3f, 0), Quaternion.Euler(0, 0, 0)) as GameObject; //instantiate: belirli bi konumda bir sey olusturmak icin
                obj_yildiz3.GetComponent<Rigidbody2D>().AddForce(new Vector3(-80f, 0, 0));
                break;
            case 4:
                GameObject obj_yildiz4 = Instantiate(yildiz4, new Vector3(9.7f, 2.9f, 0), Quaternion.Euler(0, 0, 0)) as GameObject; //instantiate: belirli bi konumda bir sey olusturmak icin
                obj_yildiz4.GetComponent<Rigidbody2D>().AddForce(new Vector3(-80f, 0, 0));
                break;
        }   
    }*/


}
