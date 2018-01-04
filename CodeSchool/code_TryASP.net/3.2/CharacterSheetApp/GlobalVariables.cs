using System.Collections.Generic;
using CharacterSheetApp.Models;
using System;

namespace CharacterSheetApp
{
  public static class GlobalVariables
  {
       // need a static property named "Equipment" that's a list of equipments, and use {get; set;} to make it available.   
       public static List<Equipment> Equipment { get; set; }
        = new List<Equipment>(); // set our Equipment property's default value to be a new list of equipment
  }
}
