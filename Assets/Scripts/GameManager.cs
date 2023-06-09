using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    [Header("Mercadoria")]
    public int mercadoriaAtual; //Quanto de Mercadoria o Jogador apanhou
    public int mercadoriaMaxima; //Numero maximod de mercadoria possivel de se apanhar
    public TMP_Text mercadoriaText;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        mercadoriaText.SetText("Mercadoria: " + mercadoriaAtual + " / " + mercadoriaMaxima);
        if (mercadoriaAtual >= mercadoriaMaxima)
        {
            mercadoriaAtual = mercadoriaMaxima;
        }
    }

    public void Mercadoria(int quantidade)
    {
        mercadoriaAtual += quantidade;
    }
}
