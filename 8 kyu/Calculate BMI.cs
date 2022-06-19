//Calculate BMI
//Write function bmi that calculates body mass index (bmi = weight / height2).

//if bmi <= 18.5 return "Underweight"

//if bmi <= 25.0 return "Normal"

//if bmi <= 30.0 return "Overweight"

//if bmi > 30 return "Obese"

  using System;
public class Kata
{
  public static string Bmi(double weight, double height)
  {
    var bmi = weight/Math.Pow(height,2);
  return bmi <= 18.5 ? "Underweight" :
         bmi <= 25.0 ? "Normal" :
         bmi <= 30.0 ? "Overweight" : "Obese";
  }
}
