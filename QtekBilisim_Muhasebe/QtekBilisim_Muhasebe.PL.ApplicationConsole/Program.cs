using QtekBilisim_Muhasebe.BL.Model.DTO.Exceptions;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QtekBilisim_Muhasebe.PL.ApplicationConsole
{
    class MyFormatException:Exception
    {
        public MyFormatException() : base("Format Hatası Yaptın Ayı")
        {

        }
    }
    class Program
    {
        static int Divide(int a, int b)
        {
            try
            {
                return a / b;
            }
            catch (DivideByZeroException)
            {

                throw new DivideByZeroException();
            }
        }
        static int ThrowFormat(string q)
        {
            try
            {
                return Convert.ToInt32(q);
            }
            catch (FormatException)
            {
                throw new MyFormatException();
            }
        }
        static void Model_1(string term)
        {
            Console.WriteLine(term);
        }
        static void Model_2(string term)
        {
           Console.WriteLine(term);
        }
        static void Model_3(string term)
        {
            Console.WriteLine(term);
        }
        static Task<string> Model_4(string term)
        {
            return Task<string>.Run(() =>
            {
                Console.WriteLine(term);
                return term;
            });
        }
        static void Main(string[] args)
        {
            int c = 0;
            try
            {
                //object nesne = 1222;
                //int y = (int)nesne;
                //Bitmap img = new Bitmap("C:\\resim.jpg");
                //throw new FileNotFoundException();
                //throw new ArgumentNullException();
                //c = Divide(3, 0);
                ThrowFormat("Güray Çalıkuşu");
                try
                {
                    int[] dizi = new int[2];
                    dizi[3] = c;
                    Console.WriteLine(c.ToString());
                }
                catch (IndexOutOfRangeException err)
                {
                    Console.WriteLine(err.Message);
                }
            }
            catch (DivideByZeroException err)
            {
                string q = err.GetType().ToString();
                StackTrace st = new StackTrace(err);
                foreach (var item in st.GetFrames())
                {
                    Console.WriteLine(item.GetMethod());
                }
                Console.WriteLine(err.Message);
            }
            catch (ArgumentNullException err)
            {
                string q = err.GetType().ToString();
                Console.WriteLine("Oha be. Hataya bak.");
            }
            catch (FileNotFoundException err)
            {
                string temp = err.GetType().ToString();
                Console.WriteLine(err.Message);
            }
            catch (InvalidCastException error)
            {
                Console.WriteLine(error.Message);
            }
            catch (NullReferenceException error)
            {
                Console.WriteLine(error.Message);
            }
            catch (ArgumentException error)
            {
                Console.WriteLine(error.Message);
            }
            catch (MyFormatException error)
            {
                Console.WriteLine(error.StackTrace.ToString());
            }
            try
            {
                Console.WriteLine("***********************************");
                Task.Delay(3000);
                Task task1 = Task.Factory.StartNew(() => Model_1("Merhaba"));
                Task task2 = Task.Factory.StartNew(() => Model_2("Yeni"));
                Task task3 = Task.Factory.StartNew(() => Model_3("Dünya"));

                Task.WhenAll(task1, task2, task3);
                throw new AggregateException();
            }
            catch (AggregateException error)
            {
                error.Handle((x) =>
                {
                    if (x is UnauthorizedAccessException)
                    {
                        return true;
                    }
                    return false;
                });
            }
            var result = Model_4("Domuz!");
            Console.WriteLine(result.Result);
            Console.ReadKey();
        }
    }
}
