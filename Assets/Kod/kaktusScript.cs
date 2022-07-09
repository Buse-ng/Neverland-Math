using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kaktusScript : MonoBehaviour
{// objelerle carpismayi engellemek icin
    public float hiz=3f;
    public Transform ilk_konum, son_konum;
    void Start()
    {
        transform.position = ilk_konum.position;
    }
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, son_konum.position, hiz * Time.deltaTime);//ilk konumdan son konuma oturuyor
        if (Vector2.Distance(transform.position, son_konum.position)<0.02f)//distance: aradaki farki olcer
        {
            Destroy(this.gameObject); //eger birbirlerine cok yakinsalar objeyi yok et
        }
    }
}
