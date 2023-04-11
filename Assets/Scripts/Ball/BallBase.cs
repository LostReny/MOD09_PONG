using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBase : MonoBehaviour
{
    // Vamos usar o Vector3 para definir a velocidade
    // desta forma acessa o x, y, z 
    // usa esse em vez de Vector2 pq estamos em um projeto 3d?

    [Header ("Variables")]
    public Vector3 speed = new Vector3(1,1);

    // Update is called once per frame
    void Update()
    {
       transform.Translate(speed); //- faz a bola se mexer
    }

        // pega a velocidade em y quando entramos em colisão 
        // e multiplica por ela mesmo em -1
        // assim quando colidir em y (bordas) retorna em valor negativo
    private void OnCollisionEnter2D(Collision2D collision) {
        if (collision.gameObject.tag == "Player"){
            speed.x *= -1;
            Debug.Log("OncollisionPlayer");
        }
        else if(collision.gameObject.tag == "Border"){
            speed.y *= -1;
            Debug.Log("OncollisionWall");
        } 
    }
    // esta entrando em colisão
    // então pq não funciona?? - simples - bordas sem rigdbody e uma borda tinha 2 box colider 
}
