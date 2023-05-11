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


    //randomizar o movimento da bola em X e Y - criando uma nova variavel de Vector em x e y
    [Header("Randomization")]
    public Vector2 randSpeedY = new Vector2(1,3);
    public Vector2 randSpeedX = new Vector2(1,3);

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
            OnPlayerCollision(); 
            // troca pelo método ali em baixo 
            /*speed.x *= -1;*/
            //Debug.Log("OncollisionPlayer");
        }
        else if(collision.gameObject.tag == "Border"){
            speed.y *= -1;
            //Debug.Log("OncollisionWall");
        }
    }
    // esta entrando em colisão
    // então pq não funciona?? - simples - bordas sem rigdbody e uma borda tinha 2 box colider 

    //criando um método para colisão com player para assim deixar ela random
    private void OnPlayerCollision(){
        speed.x *= -1;

        float rand = Random.Range(randSpeedX.x,randSpeedX.y);

        // se velocidade for neagtiva - o número rand tb será - fazendo a bola mudar de direção - ao colidir com o player muda de direção
        if(speed.x < 0)
            rand = -rand;
        speed.x = rand;

        rand = Random.Range(randSpeedY.x, randSpeedY.y);
        speed.y = rand;
    }
}
