using System.Collections.Generic;
using System;

namespace CharacterSheetApp.Models
{
  public class Equipment
  {
    public string Name;
    public static void Create(string EquipmentName){
      var equipment = new Equipment();
      equipment.Name = EquipmentName;
      GlobalVariables.Equipments.Add(equipment);
    }
    public static List<Equipment> GetAll() {
      return GlobalVariables.Equipment;
    }
  }
}
