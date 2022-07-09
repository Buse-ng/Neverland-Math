using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // butonlari kullabilmek icin
public class Leveller : MonoBehaviour
{
    public static bool level1, level2, level3; // static, diger koddan da erismemizi saglar.
    public Button level1_btn, level2_btn, level3_btn;
    //
    void Start()
    {
        level1 = true; // baslangicta sadece level1 acik o yuzden digerleri zaten false durumunda kalacak.
    }
    //
    void Update()
    {
        if (level2 == true) // eger Levelkilit kýsmýnda level2 nin kilidi acilmaya calisiyorsa 
        {
            level2_btn.interactable = true; // interactable in clickini kaldirmistik burda aciyoruz.
        }
        if (level3 == true)
        {
            level3_btn.interactable = true;
        }
    }
}