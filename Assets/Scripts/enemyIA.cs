using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyIA : MonoBehaviour
{
    // define o player que deverá ser perseguido
    public Transform meuPlayer;

    //define a velocidade do inimigo
    public float minhaVelocidade = 5;

    //distancia minima é o mais perto que o inimigo quer chegar do player
    public float distanciaMinima = 2;

    // distancia maxima é a distancia a partir da qual o inimigo resolve parar de perseguir o player
    public float distanciaMaxima = 10;

    public GameObject tiroPrefab;

    Animator anim;

    public float tempoParaTiro;

    float tempoCorrido;

    // Use this for initialization
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        // calcula a distancia entre o inimigo e o player
        float distancia = Vector2.Distance(transform.position, meuPlayer.position);

        //1 estado combate melee
        if (distancia < distanciaMinima)
        {
        }

        //2 estado o de movimentação
        if ((distancia > distanciaMinima) && (distancia < distanciaMaxima))
        {
            // move o inimigo na direção do player
            transform.position = Vector2.MoveTowards(transform.position, meuPlayer.position, minhaVelocidade * Time.deltaTime);
        }

        // 3 estado o de combate ranged
        if(distancia > distanciaMaxima)
        {
             
        }

        anim.SetFloat("distanciaPlayerEnemy", distancia);

        float deltaZ = (meuPlayer.position.z - transform.position.z);
        float deltaX = (meuPlayer.position.x - transform.position.x);
        float tgdiff = (deltaZ / deltaX);
    }


    /*
    void atirar()
    {
        tempoCorrido += Time.deltaTime;
        if (tempoCorrido > tempoParaTiro) {
            tempoCorrido = 0;
            Instantiate(tiroPrefab, transform.position, Quaternion.identity);
        }
    }

    */
}


