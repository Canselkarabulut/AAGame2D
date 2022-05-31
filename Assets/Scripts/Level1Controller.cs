using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level1Controller : MonoBehaviour
{
    [SerializeField] Animator _anim;
    [Header("Level Controller")]
    [SerializeField] float levelKacCubuktaBitsin = 10;
    public static float staticHedef;
    [Header("Sonraki Level (Level2 = 3 num. //diger leveller = num++;")]
    [SerializeField] int birSonrakiLevelSayiKodu=3;
    public static int staticLevel;

    private void Start()
    {
        staticHedef = levelKacCubuktaBitsin;
        staticLevel = birSonrakiLevelSayiKodu - 1;
    }
    private void FixedUpdate()
    {
        LevelGec();
    }
    IEnumerator GacisBekle()
    {
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene(birSonrakiLevelSayiKodu);
        yield return new WaitForSeconds(0.1f);
        KucukCubuk.cubukSayisi = 0;
    }

    //------------------------------------------------------------------------------------
    void LevelGec()
    {
        if (KucukCubuk.cubukSayisi >= levelKacCubuktaBitsin)
        {
            OyununSonu.OyunuBitir();
            _anim.SetBool("LevelBasariliMi", true);
            StartCoroutine(GacisBekle());
        }
    }

}
