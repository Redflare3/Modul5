
using System;
using System.Collections.Generic;
internal class Program();

class PemrosesData {
    public T DapatkanNilaiTerbesar<T>( T nilai1, T nilai2, T nilai3 ) {
        dynamic nil1 = (dynamic)nilai1;
        dynamic nil2 = (dynamic)nilai2;
        dynamic nil3 = (dynamic)nilai3;
        dynamic Tmax = nil1;


        if (nil2 > Tmax){
            Tmax = nil2;
        }
        if (nil3 > Tmax) {
            Tmax = nil3;
        }
        return Tmax;
    }
}
public class SimpleDatabase<T>
{
    List<T> StoredData;
    List<DateTime> inputDates;

    public SimpleDatabase()
    {
        this.StoredData = new List<T>();
        this.inputDates = new List<DateTime>();
    }

    public void addNewData(T data)
    {
        this.StoredData.Add(data);
        this.inputDates.Add(System.DateTime.Now);
    }

    public void printAllData()
    {
        for (int i = 0; i < StoredData.Count; i++)
        {
            Console.WriteLine("Data ke-" + (i + 1) + " berisi: " + StoredData[i] + " , yang disimpan pada waktu UTC: " + inputDates[i]);
        }
    }
}
public class main {
    public static void Main(string[] args) {

        PemrosesData hasil = new PemrosesData();
        float max = hasil.DapatkanNilaiTerbesar(10, 30, 22);
        Console.WriteLine("Nilai Terbesarnya adalah : " + max);
        SimpleDatabase<int> db = new SimpleDatabase<int>();

        db.addNewData(12);
        db.addNewData(34);
        db.addNewData(56);
        db.printAllData();
    } }