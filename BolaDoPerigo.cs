using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BolaDoPerigo : MonoBehaviour
{
      public AudioSource somDaMorte;
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            somDaMorte.Play();
            FindObjectOfType<GameManager>().ReiniciarPartida();
        }
    }
}
