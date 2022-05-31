using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class DonunBuyukCember : MonoBehaviour
{
    [SerializeField] float hiz;
    private void FixedUpdate()
    {
        transform.Rotate(0, 0, hiz * Time.deltaTime);
    }
}
