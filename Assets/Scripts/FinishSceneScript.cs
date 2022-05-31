using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class FinishSceneScript : MonoBehaviour
{
    public void TekrarOyna()
    {
        SceneManager.LoadScene(Level1Controller.staticLevel);
        KucukCubuk.cubukSayisi = 0;
    }
}
