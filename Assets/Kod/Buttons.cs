using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour // sahne gecis butonlari
{
    public static string sahneAd="Oyun1"; // baslangicinda oyun1 basliyor zaten diye
    public void SonrakiSahne() // menuden levele gider. bi sonraki sahneye gecer
    {
        SceneManager.LoadScene("Level");

    }
    public void OncekiSahne() // bi onceki sahneye gecer. menuye gider
    {
        SceneManager.LoadScene("Menu");
    }
    public void cikis() // oyundan cikis
    {
        Application.Quit();
    }
    public void Level_bir() // 1.oyun sahnesini acar
    {
        SceneManager.LoadScene("Oyun");
        sahneAd = "Oyun1";
    }
    public void Level_iki()
    {
        SceneManager.LoadScene("Oyun2");
        sahneAd = "Oyun2";
    }
    public void Level_uc()
    {
        SceneManager.LoadScene("Oyun3");
        sahneAd = "Oyun3";
    }
    
}
