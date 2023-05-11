using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Variavel de velocidade
    public float speed;

    // pegando o rigidbody do game object - para ter contato com a borda feita no jogo
    public Rigidbody2D myRig;

    // os inputs que devem ser acionados e podem ser alterados dentro do código
    [Header ("Inputs")]
    public KeyCode keyTypeUp = KeyCode.UpArrow;
    public KeyCode keyTypeDown = KeyCode.DownArrow;

    [Header ("CurrentPoints")]
    public int currentPoints;

    private void Awake() {
        ResetPlayer();
        // quando começar o jogo vai zerar os pontos 
    }

    private void ResetPlayer(){
        currentPoints = 0;
    }


    // fazer o meu player se mexer quando apertar o botão na posição certa 
    // como - usando o Rigbody 
    // quero mexer meu player para cima e para baixo 
    void Update()
    {
        if(Input.GetKey(keyTypeUp)){
            myRig.MovePosition(transform.position + transform.up * speed);
        }
        else if (Input.GetKey(keyTypeDown)){
            myRig.MovePosition(transform.position + transform.up * -speed);

            //se movendo ser usar o Rigidbody
            //transform.Translate(transform.up * speed * -1);
        }
    }

    public void AddPoint(){
        currentPoints++;
        Debug.Log(currentPoints);
    }
}
