using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentacaoPlayer : MonoBehaviour
{
    public double velocidadeMovimento;
    public double velocidadeRotacao;
    // Start is called before the first frame update
    void Start()
    {
        velocidadeMovimento = 1;
        velocidadeRotacao = 3;
    }
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("W")){
            transform.Translate(0,0,velocidadeMovimento);
        }
        if (Input.GetButton("S")){
            transform.Translate(0,0,-velocidadeMovimento);
        }
        if (Input.GetButton("A")){
            transform.Translate(-velocidadeMovimento,0, 0);
        }
        if (Input.GetButton("D")){
            transform.Translate(velocidadeMovimento,0,0);
        }
    }
}
