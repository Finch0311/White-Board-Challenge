public string WhiteBoard(int number)

{
    var userInput = "";    //answer not stored yet

    if(number % 3 == 0)     // if the number is divisible by 3 store "fizz"
    {
        userInput = "fizz";
    }
    if(number % 5 == 0)     // if the number is divisible by 5 store "fizz" + "buzz" 
    {
        userInput += "buzz";
    }
    return userInput;     /* since both operations work and store fizz and buzz respectively if answer is 
                          divisible by 3 and 5 "fizzbuzz" will be potrayed*/   
}