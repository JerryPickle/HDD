using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level1 : MonoBehaviour
{


    public List<Customer> CustomersList = new List<Customer>();
    private Customer badguy = new Customer();
    private PlayerController player;
    [SerializeField]private Customer[] customerSprites;
    [SerializeField]public int decoyRangeMax = 3;
    [SerializeField]public int decoyRangeMin = 1;
    [SerializeField] public int totalCustomers = 20;
    

    // Start is called before the first frame update
    void Start()
    {
        InitializeGame();

    }


    void InitializeGame()
    {

        // This function will create all of the games customers at random, it will also make a list with all of the customers, and it will make arrays of each trait type decoy.
        // We can use these arrays to help decide what clues are good/bad/really too good of a clue, by seeing how many decoys are in each array.
        
        // Create the Baddy at Complete Random, and add him to a Mast list of Customers.
        badguy.CreateCustomer();
        CustomersList.Add(badguy);



        //Create at least one other person that shares the same trait for every trait, and also add them to the list.
        int favPizzaDecoys = Random.Range(decoyRangeMin, decoyRangeMax);
        Customer[] decoy1 = new Customer[favPizzaDecoys];

        for (int i = 0; i < favPizzaDecoys; i++)
        {
            decoy1[i] = new Customer();
            CustomersList.Add(decoy1[i]);
            decoy1[i].favPizza = badguy.favPizza;
            decoy1[i].CreateCustomer();
        }

        int favDrinkDecoys = Random.Range(decoyRangeMin, decoyRangeMax);
        Customer[] decoy2 = new Customer[favDrinkDecoys];

        for (int i = 0; i < favDrinkDecoys; i++)
        {
            decoy2[i] = new Customer();
            CustomersList.Add(decoy2[i]);
            decoy2[i].favDrink = badguy.favDrink;
            decoy2[i].CreateCustomer();
        }

        int favSideDecoys = Random.Range(decoyRangeMin, decoyRangeMax);
        Customer[] decoy3 = new Customer[favSideDecoys];

        for (int i = 0; i < favSideDecoys; i++)
        {
            decoy3[i] = new Customer();
            CustomersList.Add(decoy3[i]);
            decoy3[i].favSideFood = badguy.favSideFood;
            decoy3[i].CreateCustomer();
        }

        int HatePizzaDecoys = Random.Range(decoyRangeMin, decoyRangeMax);
        Customer[] decoy4 = new Customer[HatePizzaDecoys];

        for (int i = 0; i < HatePizzaDecoys; i++)
        {
            decoy4[i] = new Customer();
            CustomersList.Add(decoy4[i]);
            decoy4[i].hatePizza = badguy.hatePizza;
            decoy4[i].CreateCustomer();
        }

        int HateDrinkDecoys = Random.Range(decoyRangeMin, decoyRangeMax);
        Customer[] decoy5 = new Customer[HateDrinkDecoys];

        for (int i = 0; i < HateDrinkDecoys; i++)
        {
            decoy5[i] = new Customer();
            CustomersList.Add(decoy5[i]);
            decoy5[i].hateDrink = badguy.hateDrink;
            decoy5[i].CreateCustomer();
        }

        int HowTipDecoys = Random.Range(decoyRangeMin, decoyRangeMax);
        Customer[] decoy6 = new Customer[HowTipDecoys];

        for (int i = 0; i < HowTipDecoys; i++)
        {
            decoy6[i] = new Customer();
            CustomersList.Add(decoy6[i]);
            decoy6[i].howTip =  badguy.howTip;
            decoy6[i].CreateCustomer();
        }

        int MoodDecoys = Random.Range(decoyRangeMin, decoyRangeMax);
        Customer[] decoy7 = new Customer[MoodDecoys];

        for (int i = 0; i < MoodDecoys; i++)
        {
            decoy7[i] = new Customer();
            CustomersList.Add(decoy7[i]);
            decoy7[i].mood = badguy.mood;
            decoy7[i].CreateCustomer();
        }


        // Figure out how many Customers are left to fill the roster and create that many at random. Then add them to the list.

        int customersRemaining = totalCustomers - Customer.CustomerCount;
        Customer[] customerFill = new Customer[customersRemaining]; 

        for (int i = 0; i < customersRemaining; i++)
        {
            customerFill[i] = new Customer();
            CustomersList.Add(customerFill[i]);
            customerFill[i].CreateCustomer();
        
        }
        
        
    }


    // Update is called once per frame
    void Update()
    {
        
    }


   
}
