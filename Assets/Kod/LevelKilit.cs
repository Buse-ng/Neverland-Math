using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //sahneler icin

public class LevelKilit : MonoBehaviour
{
    //level bitirme
    public void Level1Son()
    {
        Leveller.level2 = true;  // Levellerdeki level2 nin degerini true yapýyoruz. level1son butonuna basildiginda level 2 nin kilidi acilacak.
        SceneManager.LoadScene("Level");
    }
    public void Level2Son()
    {
        Leveller.level3 = true;
        SceneManager.LoadScene("Level");
    }
    public void Level3Son()
    {
        SceneManager.LoadScene("Level");
    }
    
}
