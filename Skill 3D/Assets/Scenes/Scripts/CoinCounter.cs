using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CoinCounter : MonoBehaviour
{
    //public int counter = 0;
    public TextMeshProUGUI text;
    public Text ScoreText;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        int counter = int.Parse(text.text);
        counter += 1;
        text.text = counter.ToString();
    }
}