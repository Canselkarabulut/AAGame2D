using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OyununSonu : MonoBehaviour
{
    public static GameObject staticDonenBuyukCember;
    public static GameObject staticSpawnLokasyonu;
    public static Animator _staticAnim;
    [SerializeField] GameObject donenBuyukCember;
    [SerializeField] GameObject spawnLokasyonu;
    [SerializeField] Animator _anim;
    private void Start()
    {
        Eslesme();
    }
    //---------------------------------------------------------------------------------------
    void Eslesme()
    {
        staticDonenBuyukCember = donenBuyukCember;
        staticSpawnLokasyonu = spawnLokasyonu;
        _staticAnim = _anim;
    }
    public static void OyunuBitir()
    {
        staticDonenBuyukCember.GetComponent<DonunBuyukCember>().enabled = false;
        staticSpawnLokasyonu.GetComponent<KucukCubukSpawner>().enabled = false;
    }
}
