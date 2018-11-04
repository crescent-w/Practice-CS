using System;
using System.Collections.Generic;
using System.Linq;
using System.Timers;
using System.Threading;
using System.Reflection;


//-------------------------------------------------------------------
// Index for test functions
//
//  ReadAndWriteFile
//  TestThreadJoin
//  Uses_Indexer
//  TestForDataConvert
//-------------------------------------------------------------------

#region ReadAndWriteFile
//public class ReadAndWriteFile
//{
//    public static void Main(string[] args)
//    {
//        string filePath = @"TestForRead.txt";

		
//        // Judge the file, method 1: 
//        //FileInfo myFileInfo = new FileInfo(filePath);

//        //if (!myFileInfo.Exists)
//        //{
//        //    Console.WriteLine(filePath + " does not exist!");
//        //}

//        // Judge the file, method 2:
//        if (!File.Exists(filePath))
//        {
//            Console.WriteLine(filePath + " does not exist!");
//        }
		
//        try
//        {
//            StreamReader mySR = new StreamReader(filePath);

//            // 1. Read the whole file.
//            //string str = mySR.ReadToEnd();
//            //mySR.Close();
//            //Console.WriteLine(str);
//            //Console.ReadKey();
			
//            //-------------------------------------------------------

//            // 2. Read the line one by one.
//            string sLine = "";
//            List<string> LineList = new List<string>();
//            //while (sLine != null)
//            while (mySR.Peek() >= 0)
//            {
//                sLine = mySR.ReadLine();
//                //if (sLine != null && !sLine.Equals(""))
//                {
//                    LineList.Add(sLine);
//                }
//            }
//            mySR.Close();

//            foreach (string s in LineList)
//            {
//                Console.WriteLine(s);
//            }
//            Console.ReadKey();
			
//        }
//        catch (IOException ex)
//        {
//            Console.WriteLine("Read file " + filePath + " fail!");
//            Console.WriteLine(ex.Message);
//        }

//        try
//        {
//            // 3. Write to file

//            //FileStream fs = new FileStream("TestForWrite.txt", FileMode.Create);
//            //StreamWriter mySW = new StreamWriter(fs);

//            // If the file exists and append is false, the file is overwritten. 
//            // If the file exists and append is true, the data is appended to the file. Otherwise, a new file is created. 
//            StreamWriter mySW = new StreamWriter(filePath, false);
			
//            //开始写入
//            mySW.Write("This is test for write file.");
			
//            //清空缓冲区
//            mySW.Flush();
			
//            //关闭流
//            mySW.Close();
//            //fs.Close();

//            // Open the file
//            System.Diagnostics.Process.Start(filePath);
//        }
//        catch (IOException ex)
//        {
//            Console.WriteLine("Write file " + filePath + " fail!");
//            Console.WriteLine(ex.Message);
//        }
//    }
//}
#endregion
//-------------------------------------------------------------------

//-------------------------------------------------------------------

#region TestThreadJoin
//namespace TestThreadJoin
//{
//    class Program
//    {
//        static void Main()
//        {
//            System.Threading.Thread x = new System.Threading.Thread(new System.Threading.ThreadStart(f1));
//            x.Start();
//            Console.WriteLine("This is Main.{0}", 1);
//            x.Join();   //阻塞自己线程，让x线程执行
//            Console.WriteLine("This is Main.{0}", 2);
//            Console.ReadLine();
//        }
//        static void f1()
//        {
//            System.Threading.Thread y = new System.Threading.Thread(new System.Threading.ThreadStart(f2));
//            y.Start();
//            y.Join();
//            Console.WriteLine("This is F1.{0}",1);
//        }

//        static void f2()
//        {
//            Console.WriteLine("This is F2.{0}", 1);
//        }
//    }
//}

#endregion
//-------------------------------------------------------------------

#region Uses_Indexer
//namespace Uses_Indexer
//{
//    class SampleCollection<T>
//    {
//        private T[] arr = new T[100];
//        public T this[int i]
//        {
//            get
//            {
//                return arr[i];
//            }
//            set
//            {
//                arr[i] = value;
//            }
//        }
//    }

//    // This class shows how client code uses the indexer
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            SampleCollection<string> stringCollection = new SampleCollection<string>();
//            stringCollection[0] = "Hello, World";
//            System.Console.WriteLine(stringCollection[0]);

//            Console.ReadKey();
//        }
//    }
//}
#endregion
//-------------------------------------------------------------------

//-------------------------------------------------------------------

#region TestForDataConvert
//class program
//{
//    static void Main()
//    {
//        char Delimiter = Convert.ToChar(Int32.Parse("44"));
//        DateTime UnitStart = DateTime.Parse("2012-07-16T09:30:47Z");

//        string str = "12";
//        short sh = Int16.Parse(str);
//    }
//}

#endregion
//-------------------------------------------------------------------

//class program
//{
//    private static List<Tuple<TestPlan, short, DateTime>> testPlans = new List<Tuple<TestPlan, short, DateTime>>();
//    static TestPlan LoadTestPlan(string group, string name, short version)
//    {
//        var testPlanTuple = testPlans.FirstOrDefault(tp => tp.Item1.TestPlanGroup == group && tp.Item1.TestPlanName == name && (tp.Item1.TestPlanVersion == version || version <= 0));
//        if (testPlanTuple == null)
//        {
//            bool b = testPlans.Any();
//            if (b)
//            {
//                short s = testPlans.Max(tp => tp.Item2);
//            }
//            short slot = testPlans.Any() ? testPlans.Max(tp => tp.Item2) : (short)0;
//            slot++;
//            if (testPlans.Count > 2)
//            {
//                DateTime dt = testPlans.Min(t => t.Item3);
//                var oldest = testPlans.First(tp => tp.Item3 == testPlans.Min(t => t.Item3));
//                //oldest.Item1.RemoveTestPlan();
//                slot = oldest.Item2;
//                testPlans.Remove(oldest);
//            }
//            var newTP = new TestPlan(slot, group, name, version);
//            testPlans.Add(new Tuple<TestPlan, short, DateTime>(newTP, slot, DateTime.Now));
//            return newTP;
//        }
//        else
//            return testPlanTuple.Item1;
//    }

//class Account 
//{
//   int balance;

//   Random r = new Random();

//   public Account(int initial) 
//   {
//	  balance = initial;
//   }

//   int Withdraw(int amount) 
//   {

//	  // This condition will never be true unless the lock statement
//	  // is commented out:
//	  if (balance < 0) 
//	  {
//		 throw new Exception("Negative Balance");
//	  }

//	  // Comment out the next line to see the effect of leaving out 
//	  // the lock keyword:
//	  lock (this)
//	  {
//		 if (balance >= amount) 
//		 {
//			Console.WriteLine("Balance before Withdrawal :  " + balance);
//			Console.WriteLine("Amount to Withdraw        : -" + amount); 
//			balance = balance - amount;
//			Console.WriteLine("Balance after Withdrawal  :  " + balance);
//			return amount;
//		 }
//		 else 
//		 {
//			return 0; // transaction rejected
//		 }
//	  }
//   }

//   public void DoTransactions() 
//   {
//	  for (int i = 0; i < 100; i++) 
//	  {
//		 Withdraw(r.Next(1, 100));
//	  }
//   }
//}

//class Test 
//{
//   public static void Main() 
//   {
//	  Thread[] threads = new Thread[10];
//	  Account acc = new Account (1000);
//	  for (int i = 0; i < 10; i++) 
//	  {
//		 Thread t = new Thread(new ThreadStart(acc.DoTransactions));
//		 threads[i] = t;
//	  }
//	  for (int i = 0; i < 10; i++) 
//	  {
//		 threads[i].Start();
//	  }
//   }
//}


namespace PracticeCS
{
	public abstract class A
	{
		public A(int _a1)
		{
			int a = 2 / _a1;
		}
		
		public void func()
		{
			int ff = 1;
		}
	}

	public class AA : A
	{
		public AA(int a) : base(a) { }

		public void newfunc() { }

	}

	public abstract class B
	{
		public int a1 { get; set; }
		public int b1 { get; set; }
		public int c1 { get; private set; }
	}

	public class BB : B
	{
		public int aa1 { get; set; }
		public int bb1 { get; set; }
	}

	class TestT
	{
		public static void RefPara(ref int refa)
		{
			int a = refa;
			refa = 2;
		}

		public static void OutPara(out int outa)
		{
			outa = 0;
			int a = outa;
			outa = 3;
		}

		public static void ParamsPara(params int[] para)
		{
			int a = para[0];

			int b = para[1];
		}


		static void Main()
		{
			BB b = new BB();
			
			
			
			//RefPara(ref i);
			//OutPara(out i);
			//int[] arr = { 1 };
			//ParamsPara(arr);
		}
	}
}
