using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Main : MonoBehaviour
{
    [SerializeField] Text cubukSayisiTxt;
    [SerializeField] Text levelTxt;
    [SerializeField] Text hedefTxt;
     int SonSahneNumarasi=4;
    public static int sonSahne;
    private void Start()
    {
        sonSahne = SonSahneNumarasi;
        KucukCubuk.cubukSayisi = 0;
    }
    private void FixedUpdate()
    {
        cubukSayisiTxt.text = KucukCubuk.cubukSayisi.ToString();
        levelTxt.text = "Level: \n" + Level1Controller.staticLevel.ToString();
        hedefTxt.text = "Hedef: \n" + Level1Controller.staticHedef.ToString();
    }
}
