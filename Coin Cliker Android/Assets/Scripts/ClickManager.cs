using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ClickManager : MonoBehaviour
{
    //Clicker
    public Text ScoreText; // Step #1 declare
    public float currentScore;
    public float hitPower;
    public float scoreIncreasedPerSecond;
    public float x;

    //SHOP
    public int shop1prize;
    public Text shop1text;

    public int shop2prize;
    public Text shop2text;

    public int shop3prize;
    public Text shop3text;

    public int shop5prize;
    public Text shop5text;

    //AMOUNT
    public Text amount1text;
    public int amount1;
    public float amount1Profit;

    public Text amount2text;
    public int amount2;
    public float amount2Profit;

    public Text amount3text;
    public int amount3;
    public float amount3Profit;

    public Text amount4text;
    public int amount4;
    public float amount4Profit;

    //UPGRADE
    public int upgradePrize;
    public Text upgradeText;


    // Use this for initialization
    void Start()
    {
        
        //CLICKER
        currentScore = 0;
        hitPower = 1;
        scoreIncreasedPerSecond = 1;
        x = 0f;

        //WE MUST EST ALL DEFAULT VARIABLES BEFORE LOAD
        shop1prize = 100;
        shop2prize = 1000;
        shop3prize = 8500;
        shop5prize = 1000000000;
        amount1 = 0;
        amount1Profit = 1;
        amount2 = 0;
        amount2Profit = 5;
        amount3 = 0;
        amount3Profit = 100;
        amount4 = 0;
        amount4Profit = 0;

        //RESET LINE
        PlayerPrefs.DeleteAll();

        //LOAD
        currentScore = PlayerPrefs.GetInt("currentScore", 0);
        hitPower = PlayerPrefs.GetInt("hitPower", 1);
        x = PlayerPrefs.GetInt("x", 0);

        shop1prize = PlayerPrefs.GetInt("shop1prize", 100);
        shop2prize = PlayerPrefs.GetInt("shop2prize", 1000);
        shop3prize = PlayerPrefs.GetInt("shop3prize", 8500);
        shop5prize = PlayerPrefs.GetInt("shop5prize", 1000000000);
        amount1 = PlayerPrefs.GetInt("amount1", 0);
        amount1Profit = PlayerPrefs.GetInt("amount1Profit", 0);
        amount2 = PlayerPrefs.GetInt("amount2", 0);
        amount2Profit = PlayerPrefs.GetInt("amount2Profit", 0);
        amount3 = PlayerPrefs.GetInt("amount3", 0);
        amount3Profit = PlayerPrefs.GetInt("amount3Profit", 0);
        amount4 = PlayerPrefs.GetInt("amount4", 0);
        amount4Profit = PlayerPrefs.GetInt("amount4Profit", 0);
        upgradePrize = PlayerPrefs.GetInt("upgradePrize", 2500);

    }



    // Update is called once per frame
    void Update()
    {

        //CLICKER
        ScoreText.text = "Coins: " + (int)currentScore + " $"; // Step #3 use the variable
        scoreIncreasedPerSecond = x * Time.deltaTime;
        currentScore = currentScore + scoreIncreasedPerSecond;

        //SHOP
        shop1text.text = "2. 1$/Second: " + shop1prize + " $";
        shop2text.text = "3. 5$/Second: " + shop2prize + " $";
        shop3text.text = "4. 100$/Second: " + shop3prize + " $";
        shop5text.text = "Win game: " + shop5prize + " $";

        //AMOUNT
        amount4text.text = "1. : " + amount4 + "x$/Click";
        amount1text.text = "2. : " + amount1 + "$/s";
        amount2text.text = "3. : " + amount2 + "$/s";
        amount3text.text = "4. : " + amount3 + "$/s";

        //UPGRADE
        upgradeText.text = "1. 2x Coins: " + upgradePrize + " $";

        //SAVE
        PlayerPrefs.SetInt("currentScore", (int)currentScore);
        PlayerPrefs.SetInt("hitpower", (int)hitPower);
        PlayerPrefs.SetInt("x", (int)x);

        PlayerPrefs.SetInt("shop1prize", (int)shop1prize);
        PlayerPrefs.SetInt("shop2prize", (int)shop2prize);
        PlayerPrefs.SetInt("shop3prize", (int)shop3prize);
        PlayerPrefs.SetInt("shop5prize", (int)shop5prize);
        PlayerPrefs.SetInt("amount1", (int)amount1);
        PlayerPrefs.SetInt("amount1Profit", (int)amount1Profit);
        PlayerPrefs.SetInt("amount2", (int)amount2);
        PlayerPrefs.SetInt("amount2Profit", (int)amount2Profit);
        PlayerPrefs.SetInt("amount3", (int)amount3);
        PlayerPrefs.SetInt("amount3Profit", (int)amount3Profit);
        PlayerPrefs.SetInt("amount4", (int)amount4);
        PlayerPrefs.SetInt("amount4Profit", (int)amount4Profit);
        PlayerPrefs.SetInt("upgradePrize", (int)upgradePrize);

        
    }

    //HIT
    public void Hit()
    {
        currentScore += hitPower;
    }

    //SHOP
    public void Shop1()
    {
        if (currentScore >= shop1prize)
        {
            currentScore -= shop1prize;
            amount1 += 1;
            amount1Profit += 1;
            x += 1;
            shop1prize += 50;

        }
    }

    public void Shop2()
    {
        if (currentScore >= shop2prize)
        {
            currentScore -= shop2prize;
            amount2 += 5;
            amount2Profit += 5;
            x += 5;
            shop2prize += 300;

        }
    }

    public void Shop3()
    {
        if (currentScore >= shop3prize)
        {
            currentScore -= shop3prize;
            amount3 += 100;
            amount3Profit += 100;
            x += 100;
            shop3prize += 1500;

        }
    }

    //UPGRADE
    public void Upgrade()
    {
        if (currentScore >= upgradePrize)
        {
            currentScore -= upgradePrize;
            hitPower *= 2;
            upgradePrize *= 3;
            amount4 += 2;
        }
    }

    public void WinGame()
    {
        if (currentScore >= shop5prize)
        {
            Debug.Log("Peli restarttas");
            Application.LoadLevel(Application.loadedLevel);
            //SceneManager.LoadScene("WinScene");
        }
    }



}

