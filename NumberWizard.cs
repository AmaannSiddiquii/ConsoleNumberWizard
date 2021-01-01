using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    int max;
    int min;
    int guess;

    // Start is called before the first frame update
    void Start()
    {
        StartGame();
    }

    void StartGame()
    {
        max = 1000;
        min = 1;
        guess = 500;
        Debug.Log("Welcome to number wizard!");
        Debug.Log("Please think of a number, keep it a secret");
        Debug.Log("The highest number you can choose is: " + max);
        Debug.Log("The lowest number you can choose is: " + min);
        Debug.Log("Is your number higher or lower than: " + guess + "?");
        Debug.Log("Push Up Arrow = If it is Higher, Push Down Arrow = If it is Lower, Push Enter = If it is Correct");
        max = max + 1;
    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            min = guess;
            NextGuess();

        }

        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            max = guess;
            NextGuess();

        }

        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("BINGO! Guessed it!");
            StartGame();
        }
    }
    
    void NextGuess()
    {
        guess = (max + min) / 2;
        Debug.Log("So is it higher or lower than: " + guess);
    }
}
