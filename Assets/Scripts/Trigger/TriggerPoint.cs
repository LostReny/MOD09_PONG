using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerPoint : MonoBehaviour
{
    // cria uma variavel na memória para usar a tag ball
    // para contar o ponto do jogador - devemos colocar ele dentro do código
    public string tagToCheck = "Ball";

    public Player player;


    // método para checar a colisão do trigger 
    // só funciona quando o objeto tem rigdbody
    // se a colisão do transform da tag (objeto) for a bola - debug + count point
    private void OnTriggerEnter2D(Collider2D collision) {
        if(collision.transform.tag == tagToCheck){
             Debug.Log("Bati na bola");
             CountPoint();
        }
       
    }

    public void CountPoint(){
        player.AddPoint();
    }
}
