using library;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace lab10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 часть");
            zAircraft[] AircraftArray = new zAircraft[21];
            for (int i = 0; i < AircraftArray.Length; i += 3)
            {
                Helicopter helicopter = new Helicopter(); // Добавляем вызов конструктора вертолета
                helicopter.RandomInit();
                AircraftArray[i] = helicopter;

                Airplane airplane = new Airplane(); // Добавляем вызов конструктора самолета
                airplane.RandomInit();
                AircraftArray[i + 1] = airplane;

                Fighterjet fighterjet = new Fighterjet(); // Добавляем вызов конструктора истребителя
                fighterjet.RandomInit();
                AircraftArray[i + 2] = fighterjet;
            }

            DisplayWithoutVirtual(AircraftArray);

            DisplayWithVirtual(AircraftArray);

            Console.WriteLine("\n2 часть");

            HelicopterWithMostBlades(AircraftArray);

            TotalCrewMembersOfFighterjetsByClass(AircraftArray, "Фронтовой");

            AircraftManufacturedAfterYear(AircraftArray, 2020);

            ModelsWithMaxFlightRange(AircraftArray);

            Console.WriteLine("\n3 часть");
            IInit[] initarr = new IInit[20];
            for (int i = 0; i <= 19; i += 4)
            {
                initarr[i] = new Runner();
                initarr[i].RandomInit();
                initarr[i + 1] = new Helicopter();
                initarr[i + 1].RandomInit();
                initarr[i + 2] = new Airplane();
                initarr[i + 2].RandomInit();
                initarr[i + 3] = new Fighterjet();
                initarr[i + 3].RandomInit();
            }
            DisplayIInitArray(initarr);

            zAircraft[] AircraftArray2 = new zAircraft[21];
            for (int i = 0; i <= 20; i += 3)
            {
                Airplane airplane = new();
                airplane.RandomInit();
                AircraftArray2[i] = airplane;

                Fighterjet fighterjet = new();
                fighterjet.RandomInit();
                AircraftArray2[i + 1] = fighterjet;

                Helicopter helicopter = new();
                helicopter.RandomInit();
                AircraftArray2[i + 2] = helicopter;
            }
            DisplayUnsortedArray(AircraftArray2);

            Helicopter element1 = new Helicopter("Ми-8", 2000, "ДВС", 1, 2, 1);
            Helicopter element2 = new Helicopter("Ми-24", 2008, "ДВС", 1, 1, 78);
            AircraftArray2[1] = element1;
            AircraftArray2[2] = element2;

            SortAndDisplayByReleaseYear(AircraftArray2);
            Console.WriteLine("\nБинарный поиск для элемента в массиве отсортированном по году выпуска:");
            Console.WriteLine($"Вертолет 1: {element1}");
            Console.WriteLine($"Вертолет 2: {element2}");

            int pos1 = Array.BinarySearch(AircraftArray2, element1);
            int pos2 = Array.BinarySearch(AircraftArray2, element2);
            Console.WriteLine($"Позиция вертолета 1: {pos1 + 1}");
            Console.WriteLine($"Позиция вертолета 2: {pos2 + 1}");

            Fighterjet element3 = new Fighterjet("Су-57", 10, "ТРД", 100, 3, 56, "Перехватчик", 13);
            Fighterjet element4 = new Fighterjet("МиГ-31", 10, "ТРД", 100, 3, 56, "Перехватчик", 14);
            AircraftArray2[3] = element3;
            AircraftArray2[4] = element4;

            SortAndDisplayById(AircraftArray2);
            Console.WriteLine("\nБинарный поиск для элемента в массиве отсортированном по id:");
            Console.WriteLine($"Истребитель 1: {element3}");
            Console.WriteLine($"Истребитель 2: {element4}");
            int pos3 = Array.BinarySearch(AircraftArray2, element3, new Sortid());
            int pos4 = Array.BinarySearch(AircraftArray2, element4, new Sortid());
            Console.WriteLine($"Позиция истребителя 1: {pos3 + 1}");
            Console.WriteLine($"Позиция истребителя 2: {pos4 + 1}");

            Console.WriteLine("\nКопирование:");
            zAircraft f = new zAircraft();
            f.RandomInit();
            Copying(f);

            static void HelicopterWithMostBlades(zAircraft[] aircraftArray)
            {
                int maxBlades = 0;
                string helicopterWithMostBlades = "";
                bool foundHelicopter = false;

                foreach (var aircraft in aircraftArray)
                {
                    if (aircraft is Helicopter)
                    {
                        if (((Helicopter)aircraft).NumberBlades > maxBlades)
                        {
                            maxBlades = ((Helicopter)aircraft).NumberBlades;
                            helicopterWithMostBlades = aircraft.Model;
                        }
                        foundHelicopter = true;
                    }
                }
                if (!foundHelicopter)
                {
                    Console.WriteLine($"в данном массиве нет вертолетов");
                }
                else
                {
                    Console.WriteLine("Вертолет с наибольшим количеством лопастей:");
                    Console.WriteLine($"{helicopterWithMostBlades} ({maxBlades})");
                }
            }
            static void TotalCrewMembersOfFighterjetsByClass(zAircraft[] aircraftArray, string fighterjetClass)
            {
                int totalCrewMembers = 0;

                foreach (var aircraft in aircraftArray)
                {
                    if (aircraft.GetType() == typeof(Fighterjet))
                    {
                        Fighterjet fighterjet = aircraft as Fighterjet;
                        if (fighterjet.ClassFighterjet == fighterjetClass)
                        {
                            totalCrewMembers += fighterjet.CrewMembers;
                        }
                    }
                }

                Console.WriteLine($"Общее количество членов экипажа истребителей класса '{fighterjetClass}': {totalCrewMembers}");
            }

            static void AircraftManufacturedAfterYear(zAircraft[] aircraftArray, int year)
            {
                Console.WriteLine($"Список воздушных судов, произведенных после {year} года:");
                bool foundAircraft = false;

                foreach (var aircraft in aircraftArray)
                {
                    if (aircraft.GetType() == typeof(Airplane) && (aircraft as Airplane).ReleaseYear > year)
                    {
                        Console.WriteLine($"{aircraft.Model} ({(aircraft as Airplane).ReleaseYear})");
                        foundAircraft = true;
                    }
                }

                if (!foundAircraft)
                {
                    Console.WriteLine($"нет воздушных судов, произведенных после {year} года.");
                }
            }

            static void ModelsWithMaxFlightRange(zAircraft[] aircraftArray)
            {
                int maxFlightRange = 0;
                string modelWithMaxFlightRange = "";
                bool foundAirplane = false;

                foreach (var aircraft in aircraftArray)
                {
                    if (aircraft is Airplane)
                    {
                        if (((Airplane)aircraft).MaxDistance > maxFlightRange)
                        {
                            maxFlightRange = ((Airplane)aircraft).MaxDistance;
                            modelWithMaxFlightRange = aircraft.Model;
                        }
                        foundAirplane = true;
                    }
                }
                if (!foundAirplane)
                {
                    Console.WriteLine($"в данном массиве нет самолетов");
                }
                else
                {
                    Console.WriteLine("Модель самолета с самой максимальной дальностью полета:");
                    Console.WriteLine($"{modelWithMaxFlightRange} ({maxFlightRange})");
                }
            }

            static void DisplayWithoutVirtual(zAircraft[] aircraftArray)
            {
                Console.WriteLine("\nВывод информации без использования виртуальных функций:");
                for (int i = 0; i < aircraftArray.Length; i++)
                {
                    Console.Write($"n{i + 1}. ");
                    aircraftArray[i].ShowNotV();
                }
            }

            static void DisplayWithVirtual(zAircraft[] aircraftArray)
            {
                Console.WriteLine("\nВывод информации используя виртуальные функции:");
                for (int i = 0; i < aircraftArray.Length; i++)
                {
                    Console.Write($"n{i + 1}. ");
                    aircraftArray[i].Show();
                }
            }

            static void DisplayIInitArray(IInit[] initarr)
            {
                Console.WriteLine("Вывод объектов массива IInit");
                for (int i = 0; i < initarr.Length; i++)
                {
                    Console.WriteLine($"n{i + 1}. {initarr[i].ToString()}");
                }
            }

            static void DisplayUnsortedArray(zAircraft[] aircraftArray)
            {
                Console.WriteLine("\nНеотсортированный массив:");
                for (int i = 0; i < aircraftArray.Length; i++)
                {
                    Console.WriteLine($"n{i + 1}. {aircraftArray[i]}");
                }
            }

            static void SortAndDisplayByReleaseYear(zAircraft[] aircraftArray)
            {
                Array.Sort(aircraftArray);
                Console.WriteLine("\nМассив отсортированный по году выпуска:");
                for (int i = 0; i < aircraftArray.Length; i++)
                {
                    Console.WriteLine($"n{i + 1}. {aircraftArray[i]}");
                }
            }

            static void SortAndDisplayById(zAircraft[] aircraftArray)
            {
                Array.Sort(aircraftArray, new Sortid());
                Console.WriteLine("\nСортировка по id");
                for (int i = 0; i < aircraftArray.Length; i++)
                {
                    Console.WriteLine($"n{i + 1}. {aircraftArray[i]}");
                }
            }

            static void Copying(zAircraft f)
            {
                Console.WriteLine($"Исходный элемент: {f}");
                zAircraft copy = (zAircraft)f.ShallowCopy();
                zAircraft clone = (zAircraft)f.Clone();
                Console.WriteLine($"\nКопия: {copy}.\nКлон {clone}");

                Console.WriteLine($"\nИзменяем id на 78 и год выпуска на 1956");
                f.id.Number = 78;
                f.ReleaseYear = 1956;

                Console.WriteLine($"\nМодифицированный исходный элемент: {f}");
                Console.WriteLine($"\nКопия: {copy}.\nКлон {clone}");
            }
        }
    }
}