using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using UnityEngine;

public class MyFirstScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    // Setting Variables
        // int = whole numbers , flaot = decimals , string = characters, bool = true/false

        int playerHealth = 100;
        Debug.Log("Player Health is " + playerHealth);
        playerHealth = 50;
        Debug.Log("Player Health is " + playerHealth);

        float moveSpeed = 5.25f;
        Debug.Log("Player Speed is " + moveSpeed);

        string playerName = "Bob";
        playerName = "Tim";
        print(playerName);

        bool gameOver = false;
        gameOver = true;
        print(gameOver);

        // Challenge = Create 4 Variables that define a country

        string countryName = "United States";
        print(countryName);

        int countryPopulation = 30000000;
        print(countryPopulation);

        float highestAltitude = 1275.43f;
        print(highestAltitude);

        bool countryLandlock = false;
        print(countryLandlock);

        // Make a Scoring System
   
        int score = 0;
        score += 1;
        score += 5;
        print(score);

    // Addition
        int a = 5;
        int b = 2;
        int c = a + b;
        print(c);

    // Subtraction
        score -= 2;
        b = a - 3;

    //multiplication
        score *= 5;
        int d = a * 2;

        //Division
        score /= 2;
        int e = d / 3;

        float jumpHeight = 5.2f;
        jumpHeight *= 1.5f;

        string message = "Hello " + "World" + " and everything else";

        int sum = a + b + c + d + e;

        // Money Variable Challenge
        float money = 10;
        money += 5;
        money *= 2;
        money -= 3;
        money /= 2;
        print(money);

        // Conditions

        int points = 10;

        if (points == 10)
        {
            Debug.Log("Player Has Won!");
          
        }
        if (points != 10)
        {
            Debug.Log("Player Has Lost!");
        }

        // < Less than, <= less than or equal to
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
