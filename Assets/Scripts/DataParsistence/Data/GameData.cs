using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

[System.Serializable]
public  class GameData 
{
   
    public string data_Name;
    public int data_Point;
        

    //the values defined in this constructor will be the default values 
    //the game starts with when there´s no data to load value
    public GameData(string name, int point)
    {
        data_Name = name;
        data_Point = point;
    }



}
 