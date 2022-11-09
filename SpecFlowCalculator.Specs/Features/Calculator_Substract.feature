Feature: Calculator_Substract
Simple calculator for substarcting **two** numbers

Link to a feature: [Calculator](SpecFlowCalculator.Specs/Features/Calculator.feature)
***Further read***: **[Learn more about how to generate Living Documentation](https://docs.specflow.org/projects/specflow-livingdoc/en/latest/LivingDocGenerator/Generating-Documentation.html)**

@mytag
Scenario: Substract two numbers
	Given the first number is 80
	And the second number is 30
	When the two numbers are substarcted
	Then the result should be 50