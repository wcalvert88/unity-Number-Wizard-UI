using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour {
    [SerializeField] int max = 1000;
    [SerializeField] int min = 1;
    int guess;

	// Use this for initialization
	void Start () {
        StartGame();
    }

    void StartGame ()
    {
        max = max + 1;
        NextGuess();
    }

    void NextGuess()
    {
        guess = (max + min) / 2;
    }

    void RestartGame()
    {
        max = 1000;
        min = 1;
        guess = 500;
        StartGame();
    }

    public void OnPressHigher()
    {
        min = guess;
        NextGuess();
    }

    public void OnPressLower()
    {
        max = guess;
        NextGuess();
    }
}
