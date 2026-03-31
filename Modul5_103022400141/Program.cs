// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
internal class Program();

public class SimpleDatabase<T>{
    List<T> StoredData;
    List<DateTime> inputDates;

    public SimpleDatabase(){
        this.StoredData = new List<T>();
        this.inputDates = new List<DateTime>();
    }

    public void addNewData(T data){
        this.StoredData.Add(data);
        this.inputDates.Add(System.DateTime.Now);
    }

    public void printAllData()
    {
        for (int i = 0; i < StoredData.Count; i++){
            Console.WriteLine("Data ke-" + (i + 1) + " berisi: " + StoredData[i] + " , yang disimpan pada waktu UTC: " + inputDates[i]);
        }
    }
}
public class main{
    public static void Main(string[] args){
        SimpleDatabase<int> db = new SimpleDatabase<int>();

        db.addNewData(12);
        db.addNewData(34);
        db.addNewData(56);
        db.printAllData();
    }
}