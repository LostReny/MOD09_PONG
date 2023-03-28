using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Variavel de velocidade
    public float speed;

    // os inputs que devem ser acionados e podem ser alterados dentro do código
    [Header ("Inputs")]
    public KeyCode keyTypeUp = KeyCode.UpArrow;
    public KeyCode KeyTypeDown = KeyCode.DownArrow;


    // fazer o meu player se mexer quando apertar o botão na posição certa 
    // como - usando o Rigbody 
    // quero mexer meu player para cima e para baixo 
    void Update()
    {

    }
}
