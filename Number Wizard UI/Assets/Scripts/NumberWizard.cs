using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NumberWizard : MonoBehaviour {
    [SerializeField] int max;
    [SerializeField] int min;
    [SerializeField] TextMeshProUGUI guessText;
    int guess;

	// Use this for initialization
	void Start () {
        StartGame();
    }

    void StartGame ()
    {
        NextGuess(); 
    }

    void NextGuess()
    {
        if (min > max)
        {
            min = max;
        }
        if (max < min)
        {
            max = min;
        }
        guess = Random.Range(min, max);
        guessText.text = guess.ToString();
    }

    void RestartGame()
    {
        max = 1000;
        min = 1;
        StartGame();
    }

    public void OnPressHigher()
    {
        if (guess < max)
        {
            min = guess + 1;
            NextGuess();
        }
    }

    public void OnPressLower()
    {
        if (guess > min)
        {
            max = guess - 1;
            NextGuess();
        }
    }
}
