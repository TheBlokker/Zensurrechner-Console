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
using System.Reflection.Metadata;

namespace Zensurrechner_Console
{
	public class NotenSpeicherung
    {
        public Dictionary<string, object>? Classname { get; set; }
        public string? Klassenname { get; set; }
        public int SummeAllerNoten { get; set; }
        public int AnzahlAnNoten { get; set; }
        public int AnzahlAnNote1 { get; set; }
        public int AnzahlAnNote2 { get; set; }
        public int AnzahlAnNote3 { get; set; }
        public int AnzahlAnNote4 { get; set; }
        public int AnzahlAnNote5 { get; set; }
        public int AnzahlAnNote6 { get; set; }
		public float Durchschnitt { get;set; }
    }

    internal class Program
	{
#pragma warning disable IDE0210 // Konvertieren in Anweisungen der obersten Ebene
		static async Task Main(string[] args)
		{
            Console.ForegroundColor = ConsoleColor.White;
            await Console.Out.WriteLineAsync($"Zensurrechner - {Assembly.GetExecutingAssembly().GetName().Version.ToString()}\n");
            // Def Var
            string nameinputvalue;
			string Activity;
			string ClassName = "";


			Class class1 = new Class();

			//SaveLoad saveLoad = new SaveLoad();

			while (true)
			{


				Console.WriteLine("Was möchten Sie machen? (addpoints, listclass, resetAll, exit, gui)");
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

					//def new strings
					int sum1N = 0;
					int sum2N = 0;
					int sum3N = 0;
					int sum4N = 0;
					int sum5N = 0;
					int sum6N = 0;
					string stop = "";

					bool dontstop = true;



					Console.WriteLine("Klassennamen angeben:");
					ClassName = Console.ReadLine();
					if (ClassName == null || ClassName==""|| ClassName==" ")
					{
						dontstop = false;

                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("ERROR, FormatException");
                        Console.ForegroundColor = ConsoleColor.White;
                    }

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
							if (pointsint >= 0 && pointsint < 15  )
							{
                                int summe = sum1N + sum2N + sum3N + sum4N + sum5N + sum6N;
                                int summe2 = sum1N * 1 + sum2N * 2 + sum3N * +sum4N * 4 + sum5N * 5 + sum6N * 6;
                                ;
                                float durchschnitt;

                                durchschnitt = (float)summe2 / summe;
                                Math.Round((double)durchschnitt, 2);
                                class1.AddGrandToClas(ClassName, summe, sum1N, sum2N, sum3N, sum4N, sum5N, sum6N);
                                var notenspeicherung = new NotenSpeicherung
                                {

                                    /*Classname = new Dictionary<string, >
                                    {*/
                                    Klassenname = ClassName,
                                    SummeAllerNoten = summe2,
                                    AnzahlAnNote1 = sum1N,
                                    AnzahlAnNote2 = sum2N,
                                    AnzahlAnNote3 = sum3N,
                                    AnzahlAnNote4 = sum4N,
                                    AnzahlAnNote5 = sum5N,
                                    AnzahlAnNote6 = sum6N,
                                    AnzahlAnNoten = summe,
                                    Durchschnitt = durchschnitt
                                    //}

                                };
                                string fileName = "notensumme.json";
                                using FileStream createStream = File.Create(fileName);
                                var options = new JsonSerializerOptions { WriteIndented = true };
                                await JsonSerializer.SerializeAsync(createStream, notenspeicherung, options);
                                await createStream.DisposeAsync();
                                Console.WriteLine(File.ReadAllText(fileName));
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

				}

                if (Activity == "listclass")
                {
                    Console.WriteLine("Auflistung aller Klassen erfolgt.\nBitte warten...");
                    string fileName = "notensumme.json";
                    using FileStream openStream = File.OpenRead(fileName);
                    NotenSpeicherung? notenSpeicherung =
                        await JsonSerializer.DeserializeAsync<NotenSpeicherung>(openStream);
                    await Task.Delay(2000);
                    Console.WriteLine("Auflistung:\n");

                    Console.WriteLine($"Klassenname: {notenSpeicherung.Klassenname}\nSumme aler Notenwerte: {notenSpeicherung.SummeAllerNoten}\nAnzahl an der Note 1: {notenSpeicherung.AnzahlAnNote1}\nAnzahl an der Note 2: {notenSpeicherung.AnzahlAnNote2}\nAnzahl an der Note 3: {notenSpeicherung.AnzahlAnNote3}\nAnzahl an der Note 4: {notenSpeicherung.AnzahlAnNote4}\nAnzahl an der Note 5: {notenSpeicherung.AnzahlAnNote5}\nAnzahl an der Note 6: {notenSpeicherung.AnzahlAnNote6}\nAnzahl aller Noten: {notenSpeicherung.AnzahlAnNoten}\nDurchschnitt: {notenSpeicherung.Durchschnitt}");
                }
                if (Activity == "exit")
                {
                    bool quit;
                    Console.WriteLine("Möchten Sie wirklich verlassen?\ny/n");
                    string quitqes = "y";
                    quitqes = Console.ReadLine();
                    if (quitqes == "y")
                    {
                        quit = true;
                        return;
                    }
                }
				if (Activity == "resetAll")
				{
					

                    string fileName = "notensumme.json";
					File.Delete(fileName);
					Console.Clear();
					Console.WriteLine("Console cleared");
                    await Task.Delay(1000);
                    Console.ForegroundColor = ConsoleColor.Green;
					Console.WriteLine("Alles zurückgestzt");
					Console.ForegroundColor = ConsoleColor.White;
                }
				if (Activity == "gui")
				{
                    await Console.Out.WriteLineAsync("GUI ist leider noch nich in dieser Version.");

                }
				if (Activity == "clear")
				{
					Console.Clear();
				}
                /*else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("ERROR");
                    Console.ForegroundColor = ConsoleColor.White;
                }*/
            }





            nameinputvalue = Console.ReadLine();

			Console.WriteLine($"{nameinputvalue} wurde hinzugefügt.");
			Console.ReadKey();
		}
	}
#pragma warning restore IDE0210 // Konvertieren in Anweisungen der obersten Ebene
}
