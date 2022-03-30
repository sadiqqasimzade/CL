using System;
using System.Collections;
using CL.Models;
namespace CL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            sbyte choise;
            CustomList<int?> customList=new CustomList<int?>(10);
            do
            {
            ChoisePoint:
                try
                {
                    Console.Write("-------------\n1)Add\n2)Show\n3)Clear\n4)RemoveAt\n5)Remove\n6)Reverse\n7)exist\n8)Indexof\n9)LastIndex\nChoise:");
                    choise = Convert.ToSByte(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    goto ChoisePoint;
                }

                switch (choise)
                {
                    case 0: break;
                    case 1:
                       
                        try
                        {
                            customList.Add("string");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                            throw;
                        }
                        break;
                        case 2:
                        customList.ShowInfo();
                        break;
                    case 3:
                        customList.Clear();
                        break;
                    case 4:
                        customList.RemoveAt(2);
                        break;
                    case 5:
                        customList.Remove("string");
                        break;
                    case 6:
                        customList.Reverse();
                        break;
                    case 7:
                        Console.WriteLine(customList.Exist("string"));
                        break;
                    case 8:
                        Console.WriteLine(customList.IndexOf("string"));
                        break;
                    case 9:
                        Console.WriteLine(customList.LastIndexOf("string"));
                        break;
                    default:
                        Console.WriteLine("Wrong Input");
                        break;
                }
            } while (choise != 0);


        }
    }
}
