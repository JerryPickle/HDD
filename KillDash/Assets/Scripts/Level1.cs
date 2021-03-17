using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level1 : MonoBehaviour
{


    public List<Customer> CustomersList = new List<Customer>();
    private Customer badguy = new Customer();
    private PlayerController player;
    int currentCustomers = 0;
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
        currentCustomers++;


        //Create at least one other person that shares the same trait for every trait, and also add them to the list.
        int favPizzaDecoys = Random.Range(decoyRangeMin, decoyRangeMax);
        Customer[] decoy1 = new Customer[favPizzaDecoys];

        for (int i = 0; i < favPizzaDecoys; i++)
        {
            decoy1[i] = new Customer();
            decoy1[i].CreateCustomer();
            decoy1[i].favPizza = badguy.favPizza;
            CustomersList.Add(decoy1[i]);
            currentCustomers++;
        }

        int favDrinkDecoys = Random.Range(decoyRangeMin, decoyRangeMax);
        Customer[] decoy2 = new Customer[favDrinkDecoys];

        for (int i = 0; i < favDrinkDecoys; i++)
        {
            decoy2[i] = new Customer();
            decoy2[i].CreateCustomer();
            decoy2[i].favDrink = badguy.favDrink;
            CustomersList.Add(decoy2[i]);
            currentCustomers++;
        }

        int favSideDecoys = Random.Range(decoyRangeMin, decoyRangeMax);
        Customer[] decoy3 = new Customer[favSideDecoys];

        for (int i = 0; i < favSideDecoys; i++)
        {
            decoy3[i] = new Customer();
            decoy3[i].CreateCustomer();
            decoy3[i].favSideFood = badguy.favSideFood;
            CustomersList.Add(decoy3[i]);
            currentCustomers++;
        }

        int HatePizzaDecoys = Random.Range(decoyRangeMin, decoyRangeMax);
        Customer[] decoy4 = new Customer[HatePizzaDecoys];

        for (int i = 0; i < HatePizzaDecoys; i++)
        {
            decoy4[i] = new Customer();
            decoy4[i].CreateCustomer();
            decoy4[i].hatePizza = badguy.hatePizza;
            CustomersList.Add(decoy4[i]);
            currentCustomers++;
        }

        int HateDrinkDecoys = Random.Range(decoyRangeMin, decoyRangeMax);
        Customer[] decoy5 = new Customer[HateDrinkDecoys];

        for (int i = 0; i < HateDrinkDecoys; i++)
        {
            decoy5[i] = new Customer();
            decoy5[i].CreateCustomer();
            decoy5[i].hateDrink = badguy.hateDrink;
            CustomersList.Add(decoy5[i]);
            currentCustomers++;
        }

        int HowTipDecoys = Random.Range(decoyRangeMin, decoyRangeMax);
        Customer[] decoy6 = new Customer[HowTipDecoys];

        for (int i = 0; i < HowTipDecoys; i++)
        {
            decoy6[i] = new Customer();
            decoy6[i].CreateCustomer();
            decoy6[i].howTip =  badguy.howTip;
            CustomersList.Add(decoy6[i]);
            currentCustomers++;
        }

        int MoodDecoys = Random.Range(decoyRangeMin, decoyRangeMax);
        Customer[] decoy7 = new Customer[MoodDecoys];

        for (int i = 0; i < MoodDecoys; i++)
        {
            decoy7[i] = new Customer();
            decoy7[i].CreateCustomer();
            decoy7[i].mood = badguy.mood;
            CustomersList.Add(decoy7[i]);
            currentCustomers++;
        }


        // Figure out how many Customers are left to fill the roster and create that many at random. Then add them to the list.

        int customersRemaining = totalCustomers - currentCustomers;
        Customer[] customerFill = new Customer[customersRemaining]; 

        for (int i = 0; i < customersRemaining; i++)
        {
            customerFill[i] = new Customer();
            customerFill[i].CreateCustomer();
            CustomersList.Add(customerFill[i]);

        }
        
        
    }


    // Update is called once per frame
    void Update()
    {
        
    }


   
}
