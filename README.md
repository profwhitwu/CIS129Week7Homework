# Week 7 Homework: Methods
This assignment is meant to measure how well you understand writing methods.  You will see there are two locations for you to write methods: The `MethodsHomework` class and the `ExtensionMethodsHomework` class.  Each question will indicate which class your method should be placed in.  This assignment makes use of unit tests, which currently point at methods that do not exist.  These will cause build errors until you have written all the methods for your assignment.  It is important you spell your methods EXACTLY the same way I tell you to in each question, along with ensuring they have the same casing.  Doing so will ensure your test project can see your methods, which will enable them to run tests against them.  

1. Write a method that converts any given decimal to the nearest whole number, then returns that number. Numbers in `x.5` format should be rounded up.  Call this method `ConvertToNearestWhole` and place in the `MethodsHomework` class.

2. Write a method that takes two strings parameters, combines them, and returns them as one value.  Call this method `CombineTwoStrings` and place in the `MethodsHomework` class.

3. Write an extension method that counts the number of vowels in a string and returns the result.  Call this method `VowelCounter` and place in the `ExtensionMethodsHomework` class.

4. Write a method that takes a list of `Person` objects as a parameter.  Iterate through the list to observe each person manually.  Change their `IsEligibleForRefund` property to `true` if...
     - They are at least 18 years old
     - Are NOT a dependent
     - Have a form of income

    Otherwise, change `IsEligibleForRefund` to `false`.  Call this method `CheckTaxRefundEligibility` and place in the `MethodsHomework` class.  This method will NOT return anything.

5. Write an extension method to check if an int is even. If it is, return true.  Call this `IsIntEven` and place in the `ExtensionMethodsHomework` class.

6. Write a method to calculate income taxes.  The first parameter should contain taxable income, and the 2nd should be the percentage of income to be withheld.  Make a third optional parameter for additional taxes to withhold (should be 0 by default). Add the 2nd and third params to make the final percentage of income to withhold and use that to calculate the amount of taxes in dollars to return.  Call this method `CalculateIncomeTaxes` and place in the `MethodsHomework` class.