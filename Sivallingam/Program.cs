using System;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Linq;
using System.Collections;
using System.Xml.Linq;
using JsonReadEmployee_naveen_na.model;

class Program
{
    public static void Main(string[] args)
    {
        int row =2;
        int pagnation = 1;

        string filePath = @"H:\Sivallingam\JsonReadEmployee\JsonReadEmployee\jsconfig1.json";
                                                                                                                       
        List<object> obj = new List<object>();
        try
        {
            string jsonData = System.IO.File.ReadAllText(filePath);
            JArray jsonArray = JArray.Parse(jsonData);

            int totalObjects = jsonArray.Count;
            int totalPages = (int)Math.Ceiling((decimal)((double)totalObjects / row));

            if (pagnation <= 0 || pagnation > totalPages)
            {
                Console.WriteLine("Invalid page number.");

            }

            var pageObjects = jsonArray
                .Skip((int)((pagnation - 1) * row))
                .Take((int)row).ToList();
            foreach (var item in pageObjects)
            {
                Console.WriteLine (item);
            }


        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
        Console.WriteLine ();
    }
   
}











