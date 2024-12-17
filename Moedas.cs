using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Moedas : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        FindObjectOfType<GameManager>().moedasNaFase +=1;
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            FindObjectOfType<GameManager>().DescontarMoedas();
            Destroy(this.gameObject);
        }
    }
}
