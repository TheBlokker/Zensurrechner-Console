using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Drawing;
using Zensurrechner_Console;
using System.Text.Json;
using System.Reflection;
using System.Numerics;

namespace Zensurrechner_Console
{
    internal class Program
    {
#pragma warning disable IDE0210 // Konvertieren in Anweisungen der obersten Ebene
        static void Main(string[] args)
        {












            // Def Var
            string nameinputvalue;
            string Activity;
            string ClassName = "";


            Class class1 = new Class();

            //SaveLoad saveLoad = new SaveLoad();

            while (true)
            {


                Console.WriteLine("Was möchten Sie machen? (addpoints, createClass, listclass, resetAll)");
                Activity = Console.ReadLine();
                if (Activity == "createClass")
                {

                    Console.WriteLine("Name der Klasse eingeben:");
                    ClassName = Console.ReadLine();
                    class1.CreateClass(ClassName, 0);
                    Console.WriteLine($"Klasse {ClassName} wurde hinzugefügt");
                    string jsonString = JsonSerializer.Serialize(class1);
                    Console.WriteLine(jsonString);
                }
                if (Activity == "addpoints")
                {
                    //import old txt file
                    string pathwr = @"C:\Users\Timm\Documents\Zensurrechner\save\save1.txt";
                    
                    try
                    {
                        // Open the text file using a stream reader.
                        using (var sr = new StreamReader(pathwr))
                        {
                            // Read the stream as a string, and write the string to the console.
                            string filetxt = sr.ReadToEnd();
                            Console.WriteLine(filetxt);
                            
                            sr.Close();
                            using (var sw = new StreamWriter(pathwr))
                            {
                                sw.WriteLine(filetxt+ Environment.NewLine);
                                Console.WriteLine(filetxt);
                                sw.Close();
                            }
                        }
                    }
                    catch (IOException e)
                    {
                        Console.WriteLine("The file could not be read:");
                        Console.WriteLine(e.Message);
                    }

                    //def new strings
                    int sum1N = 0;
                    int sum2N = 0;
                    int sum3N = 0;
                    int sum4N = 0;
                    int sum5N = 0;
                    int sum6N = 0;
                    string stop = "";

                    bool dontstop = true;

                    

                  /*  using (StreamWriter outputFile = new StreamWriter(pathwr))
                    {
                        //load old fiel an new line;
                        
                    }*/

                    Console.WriteLine("Klassennamen angeben:");
                    ClassName = Console.ReadLine();

                    while (dontstop == true)
                    {
                        Console.WriteLine("Eingabe BE (von Max BE 10)");
                        string pointsstring;
                        pointsstring = Console.ReadLine();

                        int pointsint = 0;
                        //formation string in int
                        //For points
                        try
                        {
                            pointsint = Convert.ToInt32(pointsstring);
                            // calc Note
                            int noteint = 0;

                            if (pointsint >= 10 && pointsint < 15)
                            {
                                noteint = 1;
                                sum1N++;
                            }
                            if (pointsint < 10 && pointsint >= 8)
                            {
                                noteint = 2;
                                sum2N++;
                            }
                            if (pointsint < 8 && pointsint >= 7)
                            {
                                noteint = 3;
                                sum3N++;
                            }
                            if (pointsint < 7 && pointsint >= 5)
                            {
                                noteint = 4;
                                sum4N++;
                            }
                            if (pointsint < 5 && pointsint >= 3)
                            {
                                noteint = 5;
                                sum5N++;
                            }
                            if (pointsint < 3 && pointsint >= 0)
                            {
                                noteint = 6;
                                sum6N++;
                            }
                            if (pointsint >= 15 || pointsint < 0)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("ERROR, FormatException");
                                Console.ForegroundColor = ConsoleColor.White;
                            }
                            int summe = sum1N + sum2N + sum3N + sum4N + sum5N + sum6N;
                            class1.AddGrandToClas(ClassName, summe, sum1N, sum2N, sum3N, sum4N, sum5N, sum6N);
                            string jsonString = JsonSerializer.Serialize(class1);
                            Console.WriteLine(jsonString);

                            //File creation

                            using (var sr = new StreamReader(pathwr))
                            {
                                // Read the stream as a string, and write the string to the console.
                                string filetxt = sr.ReadToEnd();
                                Console.WriteLine(filetxt);

                                sr.Close();


                                using (StreamWriter outputFile = new StreamWriter(pathwr))
                                {

                                    outputFile.WriteLine(filetxt + Environment.NewLine + jsonString);
                                }
                            }
                        }

                        catch (FormatException)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("ERROR, FormatException");
                            Console.ForegroundColor = ConsoleColor.White;

                        }
                        catch (OverflowException)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("ERROR, OverflowException");
                            Console.ForegroundColor = ConsoleColor.White;

                        }
                        Console.WriteLine("Möchten sie weiter machen? Wenn nein 'stop' eingeben");
                        stop = Console.ReadLine();
                        if (stop == "stop")
                        {
                            dontstop = false;
                            
                        }
                        if (stop == "results")
                        {
                            dontstop = false;
                            //load results
                        }
                    }
                    string line;
                    string path = @"C:\Users\Timm\Documents\Zensurrechner\save\save1.txt";
                    try
                    {
                        //Pass the file path and file name to the StreamReader constructor
                        StreamReader sr = new StreamReader(path);
                        //Read the first line of text
                        line = sr.ReadLine();
                        //Continue to read until you reach end of file
                        while (line != null)
                        {
                            //write the line to console window
                            Console.WriteLine(line);
                            //Read the next line
                            line = sr.ReadLine();
                        }
                        
                        //close the file
                        sr.Close();
                        Console.ReadLine();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Exception: " + e.Message);
                    }
                    finally
                    {
                        
                        Console.WriteLine("Executing finally block.");
                        


                    }

                }

                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("ERROR");
                    Console.ForegroundColor = ConsoleColor.White;
                }

                nameinputvalue = Console.ReadLine();

                Console.WriteLine($"{nameinputvalue} wurde hinzugefügt.");
                Console.ReadKey();
            }
        }
#pragma warning restore IDE0210 // Konvertieren in Anweisungen der obersten Ebene
    }
}