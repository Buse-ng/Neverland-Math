using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hareket : MonoBehaviour
{
    public float yatayhareket=5f;
    public int hareketHiz=5;
    int ziplamaHiz=10;
    Rigidbody2D rb;

    public bool karakterzeminde=true;
    public bool faceright=true;
    void Start()
    {
        rb= GetComponent<Rigidbody2D>();// sahnedeki rb yi getirir
    }
    void Update()
    {
        yatayhareket = Input.GetAxis("Horizontal"); // a-d tus
        rb.velocity = new Vector2(yatayhareket * hareketHiz, rb.velocity.y); // velocity: yer degisme pozisyonu,hizi
        
        if (Input.GetKeyDown(KeyCode.Space) && karakterzeminde==true)
        {
            rb.velocity = Vector2.up * ziplamaHiz;
            karakterzeminde = false;
        }
        if (yatayhareket>0 && faceright == false)
        {
            donme(); 
        }
        if (yatayhareket<0 & faceright == true){
            donme();
        }
    }
    private void OnCollisionEnter2D(Collision2D temas)
    {
        if (temas.gameObject.tag== "zemin")
        {
            karakterzeminde = true;
        }
    }
    void donme() // yuzunu cevir
    {
        faceright= !faceright;
        Vector2 yeniscale = transform.localScale;
        yeniscale.x *= -1;
        transform.localScale=yeniscale;
    }
}
// GetKey: Tuþ basýlý olduðu sürece çalýþýr.
// GetKeyDown: Tuþ basýldýðýnda 1 kere çalýþýr.