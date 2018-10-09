using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealthManager : MonoBehaviour {

    public int vidaMaxima;
    public int vidaAtual;
    
    public Image barraVidaUI;
    public Text vida;

    public float larguraNormal = 100;

    // Use this for initialization
    void Start () {
        vidaAtual = vidaMaxima;
        
	}
	
	// Update is called once per frame
	void Update () {
        if(vidaAtual <= 0)
        {
            gameObject.SetActive(false);

           
            
        }

            atualiza(vidaMaxima, vidaAtual);

    }

    public void HurtPlayer(int damageToGive)
    {
        vidaAtual -= damageToGive;
    }
    public void SetMaxHealth()
    {
        vidaAtual = vidaMaxima;

    }

    public void atualiza(float vidaMaxima, float vidaAtual)
    {

        float fracaoVida = (vidaAtual / vidaMaxima);
        barraVidaUI.rectTransform.sizeDelta = new Vector2(fracaoVida * 100, 20);
        vida.text = vidaAtual.ToString();
    }
}
