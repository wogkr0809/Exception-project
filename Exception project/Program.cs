using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_project
{
    internal class Program
    {
        /*static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3 };

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(arr[i]);
            }
            Console.WriteLine("종료");// 코드실행 안됨 Console.WriteLine(arr[i])행에서 예외가 발생함

        }*/ // 기본예제 

        /*static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3 };

            try
            {
                for(int i = 0; i < 5; i++)
                {
                    Console.WriteLine(arr[i]);
                }   
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("예외 발생: " + e.Message);
            }
            finally
            {
                Console.WriteLine("종료"); // 예외가 발생하더라도 finally 블록은 실행됨
            }
        }*/ // try-catch 예제

        /*static void DoSomethring(int arg)
        {
            if (arg < 10)
                Console.WriteLine($"arg:{arg}");
            else
                throw new Exception("arg가 10보다 큽니다.");
        }
        static void Main(string[] args)
        {
            try
            {
                DoSomethring(1);
                DoSomethring(3);
                DoSomethring(5);
                DoSomethring(9);
                DoSomethring(11);
                DoSomethring(13);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
           
        }*/ //예외 던지기 예제(statement(문))

        /* static void Main(string[] args)
        {
            try
            {
                int? a = null;
                int b = a ?? throw new ArgumentNullException();
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine(e);
            }
            try
            {
                int[] array = new[] { 1, 2, 3 };
                int index = 4;
                int value = array[index >= 0 && index < 3 ? index : throw new IndexOutOfRangeException()];
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e);
            }
        }*/ // 예외 던지기 예제(expression(식))

        /*static int Divide(int dividend, int divisor)
        {
            try
            {
                Console.WriteLine("Divide() 시작 ");
                return dividend / divisor;
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Divide() 예외 발생");
                throw e;
            }
            finally
            {
                Console.WriteLine("Divide() 끝"); 
            }
        }
        static void Main(string[] args)
        {
            try
            {
                Console.Write("피제수를 입력하세요 : ");
                string temp = Console.ReadLine();
                int dividend= Convert.ToInt32(temp);

                Console.Write(" 제수를 입력하세요 : ");
                temp = Console.ReadLine();
                int divisor = Convert.ToInt32(temp);

                Console.WriteLine("{0}/{1} = {2}", dividend, divisor, Divide(dividend, divisor));   
            }
            catch(FormatException e)
            {
                Console.WriteLine("에러 : "+ e.Message);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("에러 : " + e.Message);
            }
            finally
            {
                Console.WriteLine("프로그램을 종료합니다");
            }
        }*/ //try-catch-finally 예제

        /*class InvalidArgumentException : Exception
        {
            public InvalidArgumentException()
            {
            }
            public InvalidArgumentException(string message) : base(message)
            {

            }
            public object Argument { get; set; }

            public string Range { get; set; }

        }
        class MainApp
        {
            static uint MergeARGB(uint alpha, uint red, uint green, uint blue)
            {
                uint[] args = new uint[] { alpha, red, green, blue };

                foreach (uint arg in args)
                {
                    if (arg > 255)
                        throw new InvalidArgumentException()
                        {
                            Argument = arg,
                            Range = "0~255"
                        };
                }
                return (alpha << 24 & 0xFF000000) | (red << 16 & 0X00FF0000) | (green << 8 & 0x0000FF00) | (blue & 0X000000FF);
            }
            static void Main(string[] args)
            {
                try
                {
                    Console.WriteLine("0X{0:X}", MergeARGB(255, 111, 111, 111));
                    Console.WriteLine("0X{0:X}", MergeARGB(1, 65, 192, 128));
                    Console.WriteLine("0X{0:X}", MergeARGB(0, 255, 255, 300));
                }
                catch (InvalidArgumentException e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine($"Argument:{e.Argument},Range:{e.Range}");
                }
            }
        }*/ // 사용자 정의 예외 클래스 예제

        /*class FilterableException : Exception
        {
            public  int ErrorNo { get; set; }
            
        }
        class MainApp
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Enter Number Between 0~10");
                string input = Console.ReadLine();
                try
                {
                    int num = Int32.Parse(input);
                    if (num < 0 || num > 10)
                        throw new FilterableException()
                        {
                            ErrorNo = num

                        };
                    else
                        Console.WriteLine($"Output : {num}");
                }
                catch(FilterableException e ) when( e.ErrorNo <0)
                {
                    Console.WriteLine("Negative input is not allowed.");
                }
                catch(FilterableException e) when (e.ErrorNo >10)
                {
                    Console.WriteLine("Too big number is not allowed");
                }
            }
        }*/ //예외 필터하기
    }
}
