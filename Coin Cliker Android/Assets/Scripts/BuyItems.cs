using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuyItems : MonoBehaviour{
    //SHOP
    public int shop1prize;
    public Text shop1text;

    public int shop2prize;
    public Text shop2text;

    //AMOUNT
    public Text amount1text;
    public int amount1;
    public float amount1profit;

    public Text amount2text;
    public int amount2;
    public float amount2profit;

    // Update is called once per frame
    private void Update() {

        //SHOP 
        shop1text.text = "Tier 1: " + shop1prize + " $";
        shop2text.text = "Tier 2: " + shop2prize + " $";

        //AMOUNT
        amount1text.text = "Tier 1: " + amount1 + " arts $: " + amount1profit + "/s";
        amount2text.text = "Tier 2: " + amount2 + " arts $: " + amount2profit + "/s";
    }

   




}

