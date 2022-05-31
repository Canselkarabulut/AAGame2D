using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class KucukCubuk : MonoBehaviour
{
    Rigidbody2D rb;
    [SerializeField] float hiz;
    [SerializeField] public static bool hareketKisitliMi = false;
    [SerializeField] public static int cubukSayisi;
    void Start()
    {
        Baslang�cCagir();
    }
    private void Update()
    {
        CubugunHareketi();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "DonenBuyukCember")
        {
            transform.SetParent(collision.transform);//Temas etti�i �eyin chil'i olur
            hareketKisitliMi = true;
            cubukSayisi++;
        }
        if (collision.gameObject.tag == "KucukCubuk")
        {
            OyununSonu.OyunuBitir();
            OyununSonu._staticAnim.SetBool("OyunBittimi", true);
            StartCoroutine(FinishScane());
        }
    }
    IEnumerator FinishScane()
    {
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene(Main.sonSahne);
    }

    //--------------------------------------------------------------------------------------------------------
    void Baslang�cCagir()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void CubugunHareketi()
    {
        if (hareketKisitliMi == false)
        {
            rb.MovePosition(rb.position + Vector2.up * hiz * Time.deltaTime);
        }
    }
}
