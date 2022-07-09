using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // BUTTON VS CAGIRABILMEK ICIN
using UnityEngine.SceneManagement;
public class KarakterKontrol : MonoBehaviour
{
    public Button btn,btn_go;
    public Text zaman, can, sonuc,soru;
    public GameObject soruPaneli;

    float zamanSayac = 120;
    int canSayac = 3;

    bool oyunDevam = true;
    bool oyunTamam = false;
    bool bitisTamam = true;

    public Text puan;
    public GameObject bitisObj;
    public static int puanSayac = 0;

    public Text sayi1, sayi2, islem;
    int islemSonucu;
    public Button cevapBtn, cevapBtn2;
    void Start()
    {
        canSayac = 3;
        zamanSayac = 120;
        puanSayac = 0;
        can.text = canSayac + "";
        puan.text = puanSayac + "";
        soruPaneli.SetActive(false);
        Time.timeScale = 1f;
        
    }
    void Update()
    {
        if (oyunDevam && !oyunTamam)
        {
            zamanSayac -= Time.deltaTime; // zamani saniyede 1 tane dusurecek.
            zaman.text = (int)zamanSayac + ""; // zaman sayaci float oldugu icin stringe cevirmek icin "" eklemeyi unutma.
                                              // kusuratlý degilde tam sayi olarak zamani saysin diye int e cevirdik.
        }
        else if (!oyunTamam)
        {
            sonuc.text = "Kaybettiniz!";
            btn_go.gameObject.SetActive(true);
            Time.timeScale = 0f;
        }
        //oyunun bitip bitmedigini kontrol edecegiz.
        if (zamanSayac < 0)
        {
            oyunDevam = false;
        }

        if (puanSayac == 60 && bitisTamam)
        {
            bitisObjOlusturma();
            bitisTamam = false;
        }

    }
    void bitisObjOlusturma()
    {
        GameObject go_bitisObj = Instantiate(bitisObj, new Vector3(12f, -3.0f, 0), Quaternion.Euler(0, 0, 0)) as GameObject;
        go_bitisObj.GetComponent<Rigidbody2D>().AddForce(new Vector3(-80f, 0, 0));
    }
    public void cevapButonu1()
    {
        if (int.Parse(GameObject.Find("cevap1Btn").GetComponentInChildren<Text>().text) == islemSonucu) // oyundaki cevap1btn u bulur
        {                                                                                               // butonun childlarindan text in text oxelligine ulasiyor
                                                                                                        // inte parseyle cevir
            canSayac += 1;
            can.text = canSayac + "";
            soruPaneli.SetActive(false);
        }
        else
        {
            canSayac -= 1;
            can.text = canSayac + "";
            soruPaneli.SetActive(false);
            if (canSayac <= 0)
            {
                oyunDevam = false;
            }
        }
        Time.timeScale = 1f;

    }
    public void cevapButonu2()
    {
        if (int.Parse(GameObject.Find("cevap2Btn").GetComponentInChildren<Text>().text) == islemSonucu) // oyundaki cevap1btn u bulur
        {                                                                                               // butonun childlarindan text in text oxelligine ulasiyor
                                                                                                         // inte parseyle cevir
            canSayac += 1;
            can.text = canSayac + "";
            soruPaneli.SetActive(false);
        }
        else
        {
            canSayac -= 1;
            can.text = canSayac + "";
            soruPaneli.SetActive(false);
            if (canSayac <= 0)
            {
                oyunDevam = false;
            }
        }
        Time.timeScale = 1f;
    }
    private void OnCollisionEnter2D(Collision2D cls)  // carpisma oldugunu anlamak icin kullanilir.
    {
        int rastgeleButon;// islem seçildikten sonra doðru seçeneði rastgele seçmek için oluþturuldu.
        int rastgeleSayi;// toplama ya da çýkarma iþlemlerinde rastgele bir sayý oluþturup, doðru iþlemle çýkarýlacak ve bir butona eklenecek
        Debug.Log(cls.gameObject.name); // carpisma gerceklestiginde karsi taraftaki objenin ismini verecek.
        string objName = cls.gameObject.name;
        if (objName.Equals("bitisObj(Clone)")) //equals ile bu objeye esit olup olmaigini soruyo
        {
            oyunTamam = true;
            sonuc.text = "Tebrikler! Sonraki levelin kilidini açmak için butona basýn!";
            btn.gameObject.SetActive(true);
            Time.timeScale = 0f;
        }
        if (objName.Equals("zemin") || objName.Equals("engel2") || objName.Equals("para"))
        { 
        }
        else if (objName.Equals("kalp(Clone)"))
        {
            soruPaneli.SetActive(true);
            Time.timeScale = 0f;
            Destroy(cls.gameObject);
            int say1 = Random.Range(1, 21);
            int say2 = Random.Range(1, 11);
            sayi1.text = say1 + "";
            sayi2.text = say2 + "";
            rastgeleButon = Random.Range(1, 3); //switch case içindeki dogru cevap butonlarinin yerlerini degistirmek icin. hep ayni buton dogru olmamasi icin
            rastgeleSayi = Random.Range(1, 5);//yanlýþ cevap dogru cevaba yakýn bi cevap olsun diye olusturuldu

            if (Buttons.sahneAd == "Oyun1")
            {
                int islemisareti = Random.Range(1, 3);
                switch (islemisareti)
                {
                    case 1:
                        islem.text = "+";
                        islemSonucu = say1 + say2;
                        switch (rastgeleButon)
                        {
                            case 1:
                                GameObject.Find("cevap1Btn").GetComponentInChildren<Text>().text = (say1 + say2) + "";
                                GameObject.Find("cevap2Btn").GetComponentInChildren<Text>().text = (say1 + say2 + rastgeleSayi) + "";
                                break;
                            case 2:
                                GameObject.Find("cevap1Btn").GetComponentInChildren<Text>().text = (say1 + say2 + rastgeleSayi) + "";
                                GameObject.Find("cevap2Btn").GetComponentInChildren<Text>().text = (say1 + say2) + "";
                                break;
                        }
                        break;
                    case 2:
                        islem.text = "-";
                        islemSonucu = say1 - say2;
                        switch (rastgeleButon)
                        {
                            case 1:
                                GameObject.Find("cevap1Btn").GetComponentInChildren<Text>().text = (say1 - say2) + "";
                                GameObject.Find("cevap2Btn").GetComponentInChildren<Text>().text = (say1 - say2 - rastgeleSayi) + "";
                                break;
                            case 2:
                                GameObject.Find("cevap1Btn").GetComponentInChildren<Text>().text = (say1 - say2 - rastgeleSayi) + "";
                                GameObject.Find("cevap2Btn").GetComponentInChildren<Text>().text = (say1 - say2) + "";
                                break;
                        }
                        break;
                }
            }
            if (Buttons.sahneAd == "Oyun2")
            {
                islem.text = "*";
                islemSonucu = say1 * say2;
                switch (rastgeleButon)
                {
                    case 1:
                        GameObject.Find("cevap1Btn").GetComponentInChildren<Text>().text = (say1 * say2) + "";
                        GameObject.Find("cevap2Btn").GetComponentInChildren<Text>().text = (say1 * say2 + rastgeleSayi) + "";
                        break;
                    case 2:
                        GameObject.Find("cevap1Btn").GetComponentInChildren<Text>().text = (say1 * say2 + rastgeleSayi) + "";
                        GameObject.Find("cevap2Btn").GetComponentInChildren<Text>().text = (say1 * say2) + "";
                        break;
                }
            }
            if (Buttons.sahneAd == "Oyun3")
            {
                islem.text = "/";
                islemSonucu = say1 / say2;
                switch (rastgeleButon)
                {
                    case 1:
                        GameObject.Find("cevap1Btn").GetComponentInChildren<Text>().text = (say1 / say2) + "";
                        GameObject.Find("cevap2Btn").GetComponentInChildren<Text>().text = (say1 / say2 + rastgeleSayi) + "";
                        break;
                    case 2:
                        GameObject.Find("cevap1Btn").GetComponentInChildren<Text>().text = (say1 / say2 + rastgeleSayi) + "";
                        GameObject.Find("cevap2Btn").GetComponentInChildren<Text>().text = (say1 / say2) + "";
                        break;
                }
            }
        }

        else
        {
            canSayac -= 1;     //canSayac i her carpmada 1 deger dusurecegiz.
            can.text = canSayac + "";
            if (canSayac <= 0)
            {
                oyunDevam = false;
            }
        }
        if (objName.Equals("para"))
        {
            puanSayac += 10;
            puan.text = puanSayac + "";
            Destroy(cls.gameObject);
        }
    }
}