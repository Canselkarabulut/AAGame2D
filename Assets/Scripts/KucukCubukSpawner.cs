using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KucukCubukSpawner : MonoBehaviour
{
    [SerializeField] GameObject kucukCubuk;
    [SerializeField] GameObject spawns;
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            KucukCubukSpawn();
        }
    }
   
    //-----------------------------------------------------------------------------------------------------
    public void KucukCubukSpawn()
    {
        Instantiate(kucukCubuk, transform.position, transform.rotation, spawns.transform);
        KucukCubuk.hareketKisitliMi = false;
    }
}
