// See https://aka.ms/new-console-template for more information
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
public class main {
    public static void Main(string[] args) {

        PemrosesData hasil = new PemrosesData();
        float max = hasil.DapatkanNilaiTerbesar(10,30,22);
        Console.WriteLine("Nilai Terbesarnya adalah : " + max);
    }
}