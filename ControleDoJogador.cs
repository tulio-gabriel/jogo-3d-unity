using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControleDoJogador : MonoBehaviour
{

    public float velocidadeDoJogador;
    public Rigidbody rig;
    private float movimentoX;
    private float movimentoZ;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MovimentarBola();
    }

    private void MovimentarBola()
    {
        movimentoX=Input.GetAxis("Horizontal") * velocidadeDoJogador;
        movimentoZ=Input.GetAxis("Vertical") * velocidadeDoJogador;
        rig.AddForce(movimentoX,0f,movimentoZ);
    }
}
