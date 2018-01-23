














/*


//========= 71 ==========
//This program is to practice params array in a function
using System;

namespace Test_ParamsArray_App
{
	class Test_ParamsArray
	{
		static void Main()
		{
			sum ("x y", 2.0, 3, 4);

		}

		static void sum(string s, double d, params int [] arr)
		{
			
			int sum = 0;
			foreach (int i in arr) {
				sum += i;
			}
			Console.WriteLine ("string is: {0}", s);
			Console.WriteLine ("double is: {0}", d);
			Console.WriteLine ("SUM={0}", sum);
		}

	}

}


/*


//======== 70 =========
//This program is to practice 3-dimensional array
using System;

namespace Test_3DArray_App
{
	class Test_3DArray
	{
		static void Main()
		{
			int a=1, b=2, c=3; //these have to be assigned,
			int[,,] arr = new int[a, b, c];
			for (int i = 0; i < a; i++) {
				for (int j = 0; j < b; j++) {
					for (int k = 0; k < c; k++) {
						arr [i, j, k] = (i+1) * j * k;
					}
				}
			}

			foreach (int ele in arr) {
				Console.WriteLine (ele);
			}
		
		}

	}

}

/*


//======== 69 ========
//This program is to practice jagged arrrays with higher dimension
using System;

namespace Test_JaggedArray_App
{
	class Test_JaggedArray
	{
		static void Main()
		{
			int [][][] arr = new int[2][][];

			//Not sure how to handle this. Maybe jagged arrays only are defined as '2-d' array, not
			//more dimensional.
			//arr [0][0]  = new int[] {2, 3};

		}
	}

}

/*


//========= 68 =========
//This program is to test the jagged arrays.
using System;

namespace Test_JaggedArray_App
{
	class Test_JaggedArray
	{
		static void Main()
		{
			//for jagged array, first we need to create an array of rows, and then columns for each 
			//row.
			int[] [] a = new int[2][] {new int []{2,3, 4}, new int[]{2, 3, 4}};
			//Console.WriteLine (a.Length);
			//Console.WriteLine (a[0].Length);

			foreach (int[] b in a) { //since each element in a is an array, so we should use type
									 //int [] to indicate b is an array itself.
				Console.WriteLine ("There are {0} elements", b.Length);
				foreach (int c in b) {	//since b is an array with elements of just int object,
										//the type is just int.
					Console.Write (c + " ");
				}
				Console.WriteLine ();
			}
		}

	}

}

/*


//========== 67 =========
//This program is to test the split method in string. Split() can be used in the next program, in
//which user is prompted to a question of type, name and age of their pet. So user can input
//the information in one line with single space separator. 
using System;

namespace Test_StringSplit_App
{
	class Test_StringSplit
	{
		static void Main()
		{
			string s = "love   me     , dong";

			foreach (string sub in s.Split (' ')) {
				Console.Write (sub);
			}

			Console.Write ("Enter a sentence: ");
			string sentence = Console.ReadLine ();
			foreach (var subs in sentence.Split (' ')) {
				Console.WriteLine (subs);
			}
		}
	}
}

/*


//======= 66 =======
//This program is to test the multi-dimensional array
using System;

namespace Test_MultiDimArr_App
{
	class Test_MultiDimArr
	{
		static void Main()
		{
			string type, name;

			int age, row = 2, column = 2;

			Pet[,] all_pets = new Pet [row, column];

			for (int i = 0; i < row; i++) {
				for (int j = 0; j < column; j++) {
					all_pets [i, j] = new Pet ();
					all_pets [i, j].Set_Info ();
				}
			}

			foreach (Pet pet in all_pets) {
				//pet.Display_Info ();
				pet.Get_Info (out type, out name, out age);
				Console.WriteLine (type. + "_"+ name + "_" + age.ToString ());
			}

		}

	}

	class Pet
	{
		string type, name;
		int age;

		internal void Set_Info ()
		{
			Console.Write ("Enter the type, name and age of your pet (each on a single line): ");
			type = Console.ReadLine ();
			name = Console.ReadLine ();
			age = Int32.Parse (Console.ReadLine ());
		}

		internal void Get_Info(out string pet_type, out string pet_name, out int pet_age)
		{
			pet_type = type;
			pet_name = name;
			pet_age = age;
		}

		internal void Display_Info()
		{
			Console.WriteLine ("The type of your pet is {0}, its name is {1} " +
				"and its age is {2}.", type, name, age);
		}
	}






}

/*


//======== 65 =========
//This program is to test whether a class type object can have nullable
using System;

namespace Test_ClassNullable_App
{
	class Test_ClassNullable
	{
		static void Main()
		{
			//By testing, we can not use self-defined class type as nullable.
			//User ? my_user = new User ();
		}
	}

	class User
	{
		string name;
		int age;
	}
}


/*



//======= 64 ========
//This program is to practice class arrays and ref, out keywords
using System;

namespace Test_ClassArray_App
{
	class Test_ClassArray
	{
		static void Main()
		{
			int size;
			decimal len, wid;

			Console.Write ("How many rectangles would like to have? ");
			size = Int32.Parse (Console.ReadLine ());

			Rectangle [] my_rec = new Rectangle [size];

			for (int i = 0; i < size; i++) {
				my_rec [i] = new Rectangle ();
				my_rec [i].Set_Dim ();
			}

			//just to practice another handy feature in for-loop, foreach.
			foreach (Rectangle rec in my_rec) {
				rec.Get_Dim (out len, out wid);	//inside the function, len and wid are assigned.
				Console.Write ("len={0}, wid={1}, ", len, wid);
				Console.WriteLine ("area={0}", rec.Get_Area ());

			}

		}

	}

	class Rectangle
	{
		internal decimal length, width;
		//public decimal my_length, my_width;

		public void Set_Dim()
		{
			Console.Write ("Enter the length: ");
			length = Convert.ToDecimal (Console.ReadLine ());
			Console.Write ("Enter the width: ");
			width = Convert.ToDecimal (Console.ReadLine ());
		}

		public void Get_Dim(out decimal my_length, out decimal my_width)
		{
			my_length = length;
			my_width = width;
		}

		public decimal Get_Area()
		{
			return length * width;
		}

	}
}

/*


//======== 63 ========
//This program is to test initializing in the case of out
using System;

namespace Test_Out_App
{
	class Test_Out
	{
		static void Main()
		{
			bool b=true;
			//BOOLEAN (b);	//only pass by value.
			//BOOLEAN(ref b);	//ref b, where b has to be assigned before being passed to the function.
			BOOLEAN(out b);	//out b, where b has to be assigned by the callee, not necessary by the
							//caller.
			Console.WriteLine ("Inside the Main(): "+b);
		}

		//static void BOOLEAN(bool b)
		//static void BOOLEAN(ref bool b)
		static void BOOLEAN(out bool b)
		{
			b = false;
			Console.WriteLine ("out of Main(): "+b);
		}
	}
}

/*


//======= 62 =========
//This program is to test the address of an array.
using System;

namespace Test_AddressArray_App
{
	class Test_AddressArray
	{
		static void Main()
		{
			int [] arr = new int[] {2, 3};
			//unsafe{
			//	fixed (int* p = & arr[0]){
			//		Console.WriteLine ((int) p);
			//	}
			//}
			//Still causes error. Use unsafe and fixed.
			Console.WriteLine ((int) &arr[0]);
		}
	}
}

/*



//======== 61 =======
//This program is to test the arrays of type class. Arrays of built-in type and user-defined type.
using System;

namespace Test_ArrayClass_App
{
	class Test_ArrayClass
	{
		static void Main()
		{
			int size = 4;
			//each element is an object of type Dog.
			Dog[] my_dogs = new Dog[size];
			//create an object by using new keyword.
			for (int i = 0; i < size; i++) {
				my_dogs [i] = new Dog ();
				my_dogs [i].Get_Info ();

			}

			Console.WriteLine ("****");
			for (int i = 0; i < size; i++) {
				Console.WriteLine (my_dogs [i].name + " " + my_dogs [i].color);
			}
		}
	}

	class Dog
	{
		//here internal is necessary or public, otherwise, name and color won't be accessible.
		internal string name, color;
		internal void Get_Info ()
		{
			Console.Write ("Enter the name: ");
			name = Console.ReadLine ();
			Console.Write ("Enter the color: ");
			color = Console.ReadLine ();
		}
	}

}


/*



//======== 60 ========
//This program is to test assigning to arrays in the function.
using System;

namespace Test_NewArray_App
{
	class Test_NewArray
	{
		static void Main ()
		{
			const int size = 4;
			//When an array is initialized like this, the size has to be a constant, which makes 
			//sense as the number of elements in {} is definite, so a constant number of size.
			bool[] tf = new bool[size] { false, false, false, false };

			change_array (tf, size);
			Console.Write ("\ntf is now: ");
			for (int i = 0; i < size; i++) {
				Console.Write (tf[i]+", ");
			}
		}

		static void change_array (bool [] arr, int size)
		{
			Console.Write ("arr originally is: ");
			for (int i = 0; i < arr.Length; i++) {
				Console.Write (arr [i] + ",  ");
			}

			//Here without ref or out keyword in front, new bool[] creates anothe object, instead 
			//of overwriting the original one. With ref or out, I believe the old object is 
			//overwritten.
			arr = new bool[size];

			for (int i = 0; i < size; i++) {
				switch (i % 2) {
				case 0:
					arr [i] = true;
					break;
				case 1:
					arr [i] = false;
					break;
				default:
					Console.WriteLine ("ERROR");
					break;
				}

			}
			Console.Write ("\narr now is: ");
			for (int i = 0; i < arr.Length; i++) {
				Console.Write (arr [i] + ",  ");
			}

		}
	}
}



/*


//========= 59 ==========
//This program is to test passing arrays to functions via ref and out keywords.
//ref requires the arrays to be initialized, while out does not have such requirement.
using System;

namespace Test_Arr_Ref_Out_App
{
	class Test_Arr_Ref_Out
	{
		static void Main()
		{
			int size = 4;
			decimal[] arr_dm = new decimal[size];
			double[] arr_d;

			arrays (ref arr_dm, out arr_d, size);
			display (arr_dm, arr_d);
		}

		static void arrays (ref decimal[] dm, out double [] d, int size)
		{
			//Here I just want to practice a little on type casting, so make it more complicated.
			for (double i = 0; i < (double) size; i++) {
				dm [(int) i] = (decimal)i*1.00m;
			}

			d = new double[size];
			for (int i = 0; i < size; i++) {
				d [i] = i * i;
			}

		}

		static void display(decimal [] dm, double [] d)
		{
			for (int i = 0; i < dm.Length; i++) {
				Console.WriteLine ("dm[{0}]={1}", i, dm[i]);
			}

			for (int i = d.Length-1; i >= 0; i--) {
				Console.WriteLine ("d[{0}] = {1}", i, d[i]);
			}
		}

	}
}

/*



//======= 58 ========
//This program is to test ref and out.
using System;

namespace Test_RefOut_App
{
	class Test_RefOut
	{
		static void Main()
		{
			int i = 30, x; //here x is to test the default value of int, which has not default, so
						  //it has to be assigned to a value. However for an array, there are default
						  //values for the elements.
			double j;

			ij (ref i, out j); 	//here i must be initialized, and i is modified to 3. But j is not
								//required to be initialzied first, only declared.
			Console.WriteLine ("{0}, {1}, {2}", i, j, x);
		}


		static void ij(ref int ii, out double jj)
		{
			ii = 3;
			jj = 2.3;
		}

	}

}


/*



//======== 57 ========
//This program is to practice array implementation
using System;

namespace Test_Array_App
{
	class Test_Array
	{
		static void Main ()
		{
			const int size = 4;
			int[] i_arr = new int[size] {2, 3, 4, 8};

			set_i_arr (ref i_arr, size);
		
			dispaly_i_arr (i_arr, size);
		}

		static void set_i_arr (ref int[] arr, int size)
		{
			for (int i = 0; i < size; i++) {
				Console.WriteLine (arr[i]);
			}
			//with the following line commented out, the original array will be modified.
			//the following line just create a new array, which is not the original passed array.
			//if out keyword is used, then this will modify the original array. If ref keyword is 
			//present, the array must be first initialized before calling the method, and the following
			//line will modify the original array. Anyway, ref and out both modify the original array,
			//while without which no effect takes place.
			arr = new int[size];

			//the elements not assigned is defaulted to 0 for int.
			for (int i = 0; i < size; i++) {
				arr[i] = i*i+99;
			}

		}

		static void dispaly_i_arr (int [] i_arr, int size)
		{
			for (int i = 0; i < size; i++) {
				Console.WriteLine ("i_arr[{0}] = {1}", i, i_arr[i]);
			}

		}

	}

}

/*


//======= 56 ======
//This program is to test '\0' and null
using System;

namespace Test_Null_App
{
	class Test_Null
	{
		static void Main ()
		{
			if (!('\0' == null)) {
				Console.WriteLine ("equal.");
			}
		
		}
	}
}

/*



//======= 55 ========
//This program is to test the methods of nullable type
using System;

namespace Test_NullableMethods_App
{
	class Test_NullableMethods
	{
		static void Main ()
		{
			decimal? d = 23.000m;

			if (d.HasValue) {
				Console.WriteLine (d.Value);
			}
		}
	}

}

/*



//======== 54 =======
//This program is to test null string
using System;

namespace Test_NullString_App
{
	class Test_NullString
	{
		static void Main ()
		{
			//string does not support a nullable type. In fact null is part of string.
			string s;


			//Looks like null can only be possilbe in a file, but in the command line prompt, hitting
			//only enter key does not create a null.
			do {
				s = Console.ReadLine ();
				Console.Write (s + "\n");

			} while (s != null);

			Console.WriteLine ('\0'.GetType ());

		}

	}
}


/*

//======= 53 ========
//This program is to practice nullable type variables or objects.
using System;

namespace Test_Nullable_App
{
	class Test_Nullable
	{
		static void Main()
		{
			int? a = null;
			int? b = a ?? 3;
			int? c = a ?? null;

			Console.WriteLine ("a = {0}, b = {1}, c = {2}", a, b, c);

			int? d;
			Input (out d);
			Console.WriteLine("d = {0}", d);
		}

		static void Input(out int? d)
		{
			Console.Write ("Enter an integer (can be null): ");
			string s = Console.ReadLine ();

			//Not sure what's null for string. Empty? Gonna test it.
			if (s == null) {
				Console.WriteLine ("Empty input, d is assigned to null.");
				d = null;
			} else {
				Console.WriteLine ("Non-empty input.");
				d = Convert.ToInt32 (s);
			}

		}

	}


}

/*
 


//====== 52 =========
//This program is to test the rule that a static method calls another static method without 
//instantiating it first.
using System;

namespace Test_Static_App
{
	class Test_Static
	{
		static void Main(string [] args)
		{
			string name;
			int age;
			Test_Static ts = new Test_Static ();

			Prompt_Name (out name); //Since Prompt_Name() is static, so it can be called directly.
									//Here out means returning value to the memory location called
									//name. It's like ref, but it's returning value, not accepting it.
			ts.Prompt_Age (out age);
			Change_Age (out age);

			ts.Display_Name_Age (ref name, ref age);

		}

		static void Prompt_Name (out string name)
		{
			Console.Write ("Enter your name: ");
			name = Convert.ToString (Console.ReadLine ());
		}

		void Prompt_Age(out int age)
		{
			Console.Write ("Enter your age: ");
			age = Convert.ToInt32 (Console.ReadLine ());
		}

		void Display_Name_Age (ref string name, ref int age)
		{
			Console.WriteLine ("Your name is {0}, and your age is {1}", name, age);
		}

		static void Change_Age (out int age)
		{
			age = 23;
			age = age + 1;
		}
	}
}


/*

//======== 51 ===========
//This program is to test whether static is needed in the class in which Main() is not. By my 
//experience, static is not needed. But again static is needed if the method is in another class,
//and we want to call it without instantiating it. In a whole, as long as you want to call a method 
//without instantiating it in Main() function, add static in front, no matter where the method is.
using System;

namespace Test_Static_App
{
	class Test_Static
	{
		static void Main(string [] args)
		{
			Static.prompt ();
		}

	}

	class Static
	{
		static public void prompt ()
		{
			Console.WriteLine ("Welcome! This is ");
		}
	}
}

/*


//======== 50 ==========
//This program is to test calling a method.
using System;

namespace Test_Method_App
{
	class Test_Method
	{
		static void Main (string [] args)
		{
			//Test_Method tm = new Test_Method ();

			Console.WriteLine (function (3));

		}
		//In the class where Main() is in, in order for Main to access other methods in the same
		//class without instantiation, access specifier 'static' has to be present in front of 
		//the method. Otherwise, an object has to be declared to be able to call the method.
		static int function(int i)
		{
			//Console.Write ("Enter an integer: ");
			prompt();

			int j = int.Parse (Console.ReadLine ());
			return i+j;
		}

		//Again even though prompt is not called in the Main() method, it's still required to have
		//static keyword in front of the method definition.
		static void prompt ()
		{
			Console.Write ("Enter an integer: ");
		}
	}
}


/*


//======== 49 =========
//This program is to test the public and private accessible specifiers. Since private can
//be omitted if a member variable or function is private, we just omit it.
using System;

namespace Test_PublicPrivate_App
{
	class Parent_Class
	{
		//by default, no access specifier is set to private, which can only be accessible within the
		//class.
		string name, pwd;

		//can be accessible everywhere, even outside of the namespace.
		public void Set_Info ()
		{
			Console.Write ("Enter your name: ");
			name = Console.ReadLine ();
			Console.Write ("Enter your password: ");
			pwd = Console.ReadLine ();
		}

		//internal: can be accessible within the namespace.
		internal void Get_Info()
		{
			Console.WriteLine ("Your name is {0}, and the password you entered is {1}", name, pwd);
		}

		internal void Pass ()
		{
			Console.WriteLine ("Did I pass? {0}", name == "zhao" && pwd =="dong" ? "Yes" : "No");
		}
	}

	class Test_PublicPrivate 
	{
		static void Main(string [] args)
		{
			Parent_Class pc = new Parent_Class ();

			pc.Set_Info ();
			pc.Get_Info ();
			pc.Pass ();

		}
	}
}

/*

//====== 48 =========
//Since for-loop and if statements all can neglect {} when only one statement inside the
//block, I wonder how is while and do-while loop.
//After testing, I can conclude that if(), for(), while(), do-while() can be treated as 
//conditional boolean expression followed by a block of code. If the block of codes only
//have one single line, then the curly parenthesis can be neglected, otherwise have to be
//present.
using System;

namespace Test_DoWhile_App
{
	class Test_DoWhile
	{
		static void Main(string [] args)
		{
			int i=4, j=-3;
			//i=4, j=3;	//this is wrong, only valid in initialization.

			//One statement without being included in {} is valid for while loop.
			while (i >0)
				Console.WriteLine ("i={0}, j={1}", i--, j++);

			//How about for do-while loop? It turns out to be valid too.
			do
				Console.WriteLine (i--);
			while(i > -3);
		}
	}
}


/*

//====== 47 ======
//This program is to find the primes within 100
using System;

namespace Find_Prime_App
{
	class Find_Prime
	{
		static void Main(string [] args)
		{
			int i, j;

			for (i = 1; i <= 100; i++) {
				//Console.WriteLine ("i={0}", i);
				//Here j<=i/j can make the algorithm more efficient
				for (j = 2; j <= i / 2; j++) {
					if (i%j==0) break;
				}
				//Accordingly, j>i/j
				if (j>i/2)
					Console.WriteLine (i);
			}

		}
	}
}



//======= 46 ======
//This program is to practice for and switch
using System;

namespace Test_ForSwitch_App
{
	class Test_ForSwitch
	{
		static void Main(string [] args)
		{
			char c = '3';

			//Here this is just to demonstrate that single statement in for-loop can be
			//simplified without inlcuding {}
			for (int i = 1; i <= 3; i++)
				switch (c) {
				case '1':
					Console.WriteLine (1);
					break;
				case '3':
					Console.WriteLine (3);
					break;

				}
		}
	}
}
	




//====== 45 =======
//This program is to test the body of a loop can empty.
using System;

namespace Test_BodayLoop_App
{
	class Test_BodayLoop
	{
		static void Main(string [] args)
		{
			int i = 3;

			for (; i < 7; i++) 
				//; //This semicolon means the statement inside the loop is empty. 
  				  // Without which the statement following the for loop will be iterated.
				//Or we can put {} after for (;;)

			Console.WriteLine (i);
		}
	}
}



 
//======== 44 ========
//This program is to test do..whle() loop
using System;

namespace Test_DoWhile_App
{
	class Test_DoWhile
	{
		static void Main(string [] args)
		{
			do {
				Console.Write ("Throw the dice ...");
				if (Console.ReadLine () == "exit") {
					break; 
					//return;
				}
			} while (true);

			Console.WriteLine ("Out");

		}
	}
}




//======= 43 ========
//This program is to test the precedence of && and ||. It turns out && has a higher precedence
//than ||. Hooray.
using System;

namespace Test_AndOr_App
{
	class Test_AndOr
	{
		static void Main(string [] args)
		{
			Console.WriteLine (true || true && false);
			Console.WriteLine ((true||true) && false);
			Console.WriteLine (true || (true&&false));

		}
	}
}





//===== 42 =======
//This program is to imitate the user name and password logging-in interface.
using System;

namespace Test_UserPwd_App
{
	class Test_UserPwd
	{
		static void Main(string [] args)
		{
			string name, pwd;
			int count_input = 1;

			Console.WriteLine ("You have 4 times to try your user name and password");
			Console.Write ("Enter your name: ");
			name = Console.ReadLine ();
			Console.Write ("Enter your password: ");
			pwd = Console.ReadLine ();

			while ((name != "zhao" || pwd != "dong") && count_input < 4) {
				Console.Write ("Enter your name: ");
				name = Console.ReadLine ();
				Console.Write ("Enter your password: ");
				pwd = Console.ReadLine ();
			
				count_input++;
			}
			if (count_input == 4) {
				Console.WriteLine ("You have used all your chances. Sorry.");
			}

		}
	}
}





//========== 41 ============
//This program is to practice while loop
using System;

namespace Test_WhileLoop_App
{
	class Test_WhileLoop
	{
		static void Main(string [] args)
		{
			string yn;

			while (true) {
				Console.Write ("Would you like to continue: ");
				yn = Console.ReadLine ();

				if (yn == "Y" || yn == "y") {
					//return;	//Warning: unreachable code detected. Make sense.
					break;	//only jump out of the while loop, not the whole program.
				}
			}
			Console.WriteLine ("Good, you are at the next stage now!");
		}
	}
}
	



//========= 40 ========
//This program is to test the while loop whose condition must be boolean expression or not
using System;

namespace Test_WhileBoolean_App
{
	class Test_WhileBoolean
	{
		static void Main(string [] args)
		{
			int i = 4;
			//By testing, the condition expression in while statement should be boolean, just
			//like in if () statement.
			while (Convert.ToBoolean(i)) {
				i--;
			}
			Console.WriteLine (i);
		}
	}
}





//======== 39 ========
//This program is to test Convert.ToBoolean(string)
using System;

namespace Test_ToBoolean_App
{
	class Test_ToBoolean
	{
		static void Main(string [] args)
		{
			//Afte testing, char or string can NOT be converted to boolean.
			Console.WriteLine (Convert.ToBoolean (1.0e2));

			//if (2) does NOT work in c#, has to be converted to boolean type. Convert.ToBooelan(2)
			if (2>1) {
				Console.WriteLine ("true");
			}
		}
	}
}



//====== 38 =======
//This program is to test ...
using System; 

namespace Test_ForLoop_App
{
	class Test_ForLoop
	{
		static void Main(string [] args)
		{
			int i, j;

			for (i = 1, j = 3; i < 5 && j >0; i=i+2, j--) {
				Console.WriteLine ("i={0}, j={1}", i, j);
			}

		}
	}
}




// ====== 37 =======
//This program is to test the for-loop and the scope of variables.
using System;

namespace Test_ForLoop_App
{
	class Test_ForLoop
	{
		static void Main(string [] args)
		{
			for (int i = 0; i < 9; i++) {
				Console.WriteLine ("i = {0}", i);
			}
			//Here is to test the scope of int i which is declared inside the loop. It turns
			//out i is accessible outside of the scope which it's defined in.
			//Console.WriteLine ("Outside of the for-loop, i = {0}", i);

		}
	}
}




//====== 36 =======
//This program is to test return used in a switch statement
using System;

namespace Test_ReturnSwitch_App
{
	class Test_ReturnSwitch
	{
		static void Main(string [] args)
		{
			string s, yn;

			Console.Write ("Enter the word in your heart: ");
			s = Console.ReadLine ();
			Console.Write ("Do you want to see the rest? ");
			yn = Console.ReadLine ();

			switch (s) {
			case "love":
				Console.WriteLine ("Matched");
				break;	//the statements after switch statement will be executed.
				//return; //The statements after switch statement will NOT be executed, the 
				//control jumped out of the program.
			default:
				Console.WriteLine ("Not matched");
				break;
			}

			switch (yn) {
			case "y":
			case "Y":
				break;
			case "n":
			case "N":
				return;

			}

			Console.WriteLine ("Sorry there are no other parts for you to enjoy.");
		}
	}
}




//======== 35 ========
//This program is to practice nested switch statement.
using System;

namespace Test_NestSwitch_App
{
	class Test_NestSwitch
	{
		static void Main(string [] args)
		{
			string name, pwd;

			Console.Write ("Enter your name: ");
			name = Convert.ToString (Console.ReadLine ());
			Console.Write ("Enter your password: ");
			pwd = Console.ReadLine ();

			switch (name) {
			case "ZHAO":
			case "zhao":
				switch (pwd) {
				case "VIP":
					Console.WriteLine ("{0}, you are entering the VIP page ...", name);
					Console.ReadLine ();
					break;
				case "Regular":
					Console.WriteLine ("{0}, you are entering the Regular page ...", name);
					Console.ReadLine ();
					break;
				default:
					Console.WriteLine ("{" +
						"0}, you can not enter any page ...", name);
					break;
				}
				break;
			case "DONG":
			case "dong":
				Console.WriteLine ("{0}, your page is being updated...", name);
				break;
			default:
				Console.WriteLine ("You don't belong to this family. Sorry.");
				break;

			}
		}
	}
}
	



//======= 34 ========
//This program is to test the break statement in the default case
using System;

namespace Test_BreakSwitch_App
{
	class Test_BreakSwitch
	{
		static void Main(string [] args)
		{
			bool i = true;

			//In the switch statement, the expression can be type of bool, integral, char, stirng
			//enum and nullable, the last two of which will be studied later.
			switch (i) {
			case true:
				Console.WriteLine ("1");
				break;
			case false:
				Console.WriteLine ("2");
				break;
			//Again so weird that break is required when compiled with MONO. Otherwise it
			//it Complains not being able to fall through the switch statement.
			default: 
				Console.WriteLine ("no");
				break;
			}

		}
	}
}



//====== 33 =======
//This program is to pratice switch statement.
using System; 

namespace Test_Switch_App
{
	class Test_Switch
	{
		static void Main(string [] args)
		{
			char grade;
			object o;

			Console.Write ("Enter your letter grade: ");
			o = Console.ReadLine ();
			//here is to test the input is char, but failed, as the input is always string.
			if (true) {
				Console.WriteLine (o.GetType ());
			}

			//In object methods, no ToChar(), so use class Convert.ToChar().
			grade = Convert.ToChar (o);

			switch (grade) {
			case 'A': //constants must have the same type of expression in switch 
			case 'a':
				Console.WriteLine ("Great!");
				break;
			case 'B':
			case 'b':
				Console.WriteLine ("Good!");
				break;
			case 'c':
			case 'C':
				Console.WriteLine ("Passed!");
				break;
			default:
				Console.WriteLine ("Try again!");
				break; //the break is required, otherwise the compiler complains not being able
					   //to fall out of the switch statement.
			}

			Console.WriteLine ("Your grade is {0}", grade);
		}
	}
}





//====== 32 ==========
//This program is to test ?: operator
using System;

namespace Test_Selection_App
{
	class Test_Selection
	{
		static void Main(string [] args)
		{
			object o;

			//?: can not stand as itself as it's only an expression. It returns a value.
			o = 2 > 1? true : false;

			Console.WriteLine ("{0}, {1}, {2}", o, o.ToString (), o.GetType ());

		}
	}
}
	


//======= 31 ======
//This program is to practice ! operator
using System;

namespace Test_Not_App
{
	class Test_Not
	{
		static void Main(string [] args)
		{
			//The boolean constants are true and false, which are both lowercase.
			if (!false) {
				Console.WriteLine ("False");
			} else {
				Console.WriteLine ("True");
			}

		}
	}
}




//====== 30 =======
//This program is to imitate the log-in of a user.
using System;

namespace User_Pwd_App
{
	class User_Pwd
	{
		static void Main(string [] args)
		{
			string name, pwd;

			Console.Write ("Please enter your name: ");
			name = Convert.ToString (Console.ReadLine ());

			Console.Write ("Please enter your password: ");
			pwd = Convert.ToString (Console.ReadLine ());

			//Try this example again when you learn the control flow, while loop.
			if (name == "Lianshui Zhao" && pwd == "Shaoyun Dong") {
				Console.WriteLine ("Welcome {0}!", name);
			} else {
				Console.WriteLine ("Sorry {0}, the information you entered is not right! " +
					"Exiting......", name);
			}

		}
	}
}




//======= 29 =======
//This program is to test relational operators.
using System;

namespace Test_Relational_App
{
	class Test_Relational
	{
		static void Main(string [] args)
		{
			Console.WriteLine ("{0}", 1>2);
			Console.WriteLine ("{0}", 1==1);
			Console.WriteLine ("{0}, {1}", 2!=2, Convert.ToBoolean (2.3m));
		}
	}
}
	


//======= 28 ======
//This program is to test ++ and --
using System;

namespace Test_PM_App
{
	class Test_PM
	{
		static void Main(string [] args)
		{
			int i = 3, j;

			j = i++;
			Console.WriteLine("{0}, {1}", j, i);
			j = i--;
			Console.WriteLine("{0}, {1}", j, i);

			Console.WriteLine ("{0}, {1}, {2}, {3}", 2/3, 2%3, 2.3f%3, 2.0/3);
		}
	}
}



//===== 27 ======
//This program is to test \b and \r
using System;

namespace Test_BR_App
{
	class Test_BR
	{
		static void Main(string [] args)
		{
			//\r\n is the same as Environment.NewLine, but \n\r will two lines. Not understand
			//the difference between \r and \n. \v does not work well in mono interface, but good on 
			//command line.
			Console.WriteLine ("bac\vkspace{0}w\r\n ord", Environment.NewLine);
		}
	}
}




//======== 26 ========
//This program is to test the arithmetic involving different types, decmal, double, float or int
using System;

namespace Test_ArithType_App
{
	class Test_ArithType
	{
		static void Main(string [] args)
		{
			int i = 2;
			float f = 2.23f;
			double d = 2.2323;
			decimal dm = 2.300m;
			//You can NOT mix decimal with float or double, but can work with int.
			Console.WriteLine ("{0}", d+f);

		}

	}
}




//======== 25 =========
//This program is to test const
using System;

namespace Test_Const_App
{
	class Test_Const
	{
		static void Main (string [] args)
		{
			const decimal pi = 3.141592653000m;
			decimal r;

			Console.Write ("Please enter the radius of your circle: ");
			r = decimal.Parse (Console.ReadLine ());

			Console.WriteLine("{0}, {1}", pi*r*r, pi+r);

			//This is to use Convert class to convert ReadLine() to desired type
			double d;
			Console.Write ("Enter a double type value: ");
			d = Convert.ToDouble (Console.ReadLine ());

			Console.WriteLine ("{0}", d);
		}
	}
}





//======= 24 ========
//This program is to test the string concatenation
using System;

namespace Test_StringConcate_App
{
	class Test_StringConcate
	{
		static void Main(string [] args)
		{
			//See the difference here @ and "". "" along can not cross lines without putting 
			//the other half quote on the same line. However, @"" can manage this.
			string s = "sdds" +
			           @"sdfsds
				" + "end";

			Console.WriteLine ("{0}" + "love", s);

		}
	}
}





//====== 23 ========
//This program is to test unsigned and long type
using System;


namespace Test_UL_App
{
	class Test_Class
	{

	}

	class Test_UL
	{
		static void Main (string [] args)
		{
			//the rvalue has to be matched with the type of lvalue, otherwise error.
			int ii = (int) 2.3;
			double d = (double) 2.3m;

			uint u = 23U;
			long i = 23L;
			object o = i;
			float dd = 2f;
			decimal dm = 2.3000000000m;

			Console.Write ("{0}, {1}, {2}, {3}, {4}, {5}", i, typeof(int), o.GetType (), 
				typeof(Test_Class), dd, dm);
		}
	}
}






//====== 22 =======
//This program is to test decimal type
using System;

namespace Test_Decimal_App
{
	class Test_Decimal
	{
		static void Main(string [] args)
		{
			decimal d = 2.90000m;
			float f = 2.9000f;

			Console.WriteLine ("decimal: {0}, float: {1}", d, f);
		}
	}


}





//======== 21 =========
//This program is to test Convert.ToBoolean()
using System;

namespace Test_ToBoolean_App
{
	class Test_ToBoolean
	{
		static void Main(string [] args)
		{
			int i = 3;
			float f = 2332.3f;
			double d = 2.3;
			object o = 3;

			//After testing, ToBoolean () is a method of class Convert.
			Console.WriteLine ("{0} is converted to {1}, {2}, {3}", i, Convert.ToBoolean (i),
				Convert.ToString (i)+"love", Convert.ToDouble(i));
			Console.WriteLine ("{0} is converted to {1}, {2}, {3}", f, Convert.ToBoolean (f),
				Convert.ToString(f)+"love", Convert.ToInt16(f));
			Console.WriteLine ("{0} is converted to {1}, {2}, {3}", d, Convert.ToBoolean(d),
				Convert.ToString(f)+"love", Convert.ToInt32(d));

			Console.WriteLine ("{0}, {1}, {2}", Convert.ToInt16(o)+3, Convert.ToBoolean(o),
				Convert.ToDecimal (o));


		}
	}

}





// ===== 20 =====
//This program is to test ReadLine() method
using System;

namespace Test_ReadLine_App
{
	class Test_ReadLine
	{
		static void Main (string [] args)
		{
			string name;
			float f;

			Console.Write ("Enter your name: ");
			name = Console.ReadLine ();

			Console.Write ("Enter a float number: ");
			f = float.Parse (Console.ReadLine ());
	
			Console.Clear ();
			Console.WriteLine ("The name you entered is: {0}", name);
			Console.WriteLine ("The float number you entered is: {0}", f);
			Console.ReadKey ();

		}
	}
}




//====== 19 =======
//This program is to test the method ToBoolean
using System;

namespace Test_ToBoolean_App
{
	class Test_ToBoolen
	{
		static void Main(string [] args)
		{
			int i = 3;
			double d = 2.3;
			float f = 2.32f;

			//After testing it seems int does not have method called ToBoolean().
			//Console.WriteLine ("{0}", i.ToBoolean());

		}
	}
}
	



// ====== 18 =======
//This program is to test float type without putting f as the suffix.
using System;

namespace Test_Float_App
{
	class Test_Flaot
	{
		static void Main(string [] args)
		{
			float f = 2.3e-2F; //2.3 is treated as double, so assign double to float, we should
			//do type conversion, either by (float) 2.3 or 2.3f, or even (float) 2.3f.

			Console.WriteLine ("{0}", f);
		}
	}
}




//====== 17 ========
//This program is to test object methods
using System;

namespace Test_ObjectMethod_App
{
	class Test_Object
	{
		static void Main (string [] args)
		{
			object o, oo, ooo;
			int i = 3;
			float j = 3;
			double k = 3;
			string s;

			o = i;
			oo = j;
			ooo = k;

			Console.WriteLine ("{0}, {1}", o, oo);
			Console.WriteLine ("{0}, {1}", o.Equals(oo), Equals (oo, o));

			Console.WriteLine ("{0}, {1}, {2}", o.GetType (), oo.GetType (), ooo.GetType ());

			s = o.ToString ();
			Console.WriteLine (s+s);	//concatenate
			s = 23.232e2.ToString () + "love";
			Console.Write ("{0}\n", s);
		}
	}
}


 


//====== 16 ======
//This program is to test the the type casting.
using System;

namespace Test_TypeCasting_App
{
	class Test_TypeCasting
	{
		static void Main (string [] args)
		{
			int i;
			double d;
			string s;

			//int to double
			i = 2;
			d = i; //small type to large type, so no type casting
			Console.WriteLine ("{0}", d);

			//double to int
			d = 2.323;
			i = (int)d; //large type to small type, so a type casting is required.
			Console.WriteLine ("{0}", i);

			Console.WriteLine ("{0}\t, {1}\t, {2}", sizeof(int), sizeof(double), sizeof(float));
			Console.WriteLine ("{0}\t, {1}\t, {2}", sizeof(ushort), sizeof(uint), sizeof(ulong));

			//string to numeric;
			s = "223.2e2";
			i = (int)double.Parse (s);	//You can NOT directly use int.Parse(): int.Parse("23")

			Console.WriteLine ("{0}", i);
		}

	}
}




//====== 15 ======
//This program is to test object type
using System; 
//Just like Fortran, there a program name 
namespace Test_Object_App
{
	class Test_Object
	{
		static void Main (string [] args)
		{
			object o;
			int i = 2;
			double d = 2.34e-3,
				   dd;
			string c;

			//boxing
			o = i;
			Console.WriteLine ("int: {0}", o);
			o = d;
			Console.Write ("double: {0}\ndouble: {0:f3}\n", o);
			//unboxing
			//dd = (double) (o+o); //Wrong, arithmetic operators can not work on object. why?
								   //looks like object type variable can only store values?
			dd = (double) o;	//does NOT work double(o), only (double) o.
			Console.WriteLine ("{0}", dd);

			o = "cc";
			c = (string) o;
			Console.WriteLine ("{0}", c);

			o = 233;
			//If the object is int type, so to convert to double, we need to convert to int 
			//first, then to double type.
			d = (double)(int) o;
			Console.Write ("{0}\n", d);
		}
	}
}
	


//======== 14 =======
//This program is to test object and dynamic type
using System;

class test_object
{
	static void Main ()
	{
		object o;
		//Not sure by now how to include Microsoft.CSharp.dll assembly needed in compilig 
		//dynamic type.
		//dynamic d;
		o = 2; //boxing
		Console.WriteLine (o);

		o = 3.34;
		Console.WriteLine (o);

		//d = "sd";
		//Console.WriteLine (d);
	}
}




//======= 13 =====
//This program is to practice sizeof () for built-in type and user-defined type.
using System;

class size
{
	int i;
	double d;
	char c;

}

class Test_Sizeof 
{
	static void Main (string [] args)
	{

		Console.WriteLine ("sizeof(i) is {0}", sizeof(int));
		Console.Write ("sizeof(d) is {0:f4}", sizeof(double)); 
		//NOT sure how to handle the size of a user-defined class, which is not like that in 
		//c++.
		/Console.Write ("sizeof(size) is {0}\nEND\n", sizeof(size));
	}
}




//====== 12 =======
//This program is to practice the function of Console.ReadKey()
using System; 

class Test_ReadKey
{
	static void Main ()
	{
		string key;
		//Failed in using ReadKey(), but we can use ReadLine instead.
		key = Console.ReadLine ();

		Console.WriteLine ("{0}", key);
	}
}



//====== 11 ======
//This program is to test whether we can feed arguments from outside into Main(string [] args)
//Bravo! It works as expected. 
//How to run this: csc Learning_C#.cs; mono Learning_C#.exe "argument 1" " argument 2"
using System;

class Test_Input_Main
{
	static void Main (string [] args)
	{
		Console.Write ("The first argument recevied is {0}\n", args[1]);
	}
}
	



//======= 10 ========
//This program is to test methods Console.Write() and Console.WriteLine().
using System;

class test_write
{
	static void Main ()
	{
		//The keywords in front of Write() declaration are public static void, which means
		//Write() is transparent to other class and methods, can be directly used without
		//requiring instantiation and the return type is void.
		//The difference between Write() and WriteLine() is just the newline "\n". Both
		//have the same declaration parameters.

		Console.Write ("{0}, {1}\n", "23", 23); //You can NOT put "," behind the last argument.
		Console.WriteLine ("line {0}", "", 2); //the extra argument is neglected.

	}
}




//====== 9 ========
//This program is to test if creating a Main() function without static keyword.
//After testing, the compiler still complains that there is no static Main() for entry. 
//So just create a static Main() method as a starter.
using System;

class Main_Class 
{
	public void Main()
	{
		Console.WriteLine ("Main () without static keyword in front.");
	}
}

class Test_Main_Class
{
	void Call_Main_Class ()
	{
		Main_Class my_test = new Main_Class ();

		my_test.Main();
	}

}




//======= 8 =======
//This program is to practice ReadLine and Clear methods
using System;

class test_readline 
{
	static void Main ()
	{
		Console.Write ("Enter your name: ");
		string name = Console.ReadLine ();

		Console.Write ("Enter your age: ");
		float age = float.Parse(Console.ReadLine ());

		Console.Clear ();

		Console.WriteLine ("My name is {0}, and age is {1}", name, age);
	}
}
	



//======= 7 =======
//This program is to concatenate strings.
using System;

class test_write
{
	static void Main () 
	{
		string name = "zhao" + "Lianshui";

		Console.WriteLine (name);
	}
}




//======= 6 =======
//This program is to practice Write () method in Console class
using System;

class test_write
{
	static void Main (string [] args) 
	{
		Console.Write ("This is Write () function.\n");

		Console.WriteLine ("This is WriteLine() function  \n    =====");
	}
}




//========= 5 ========
//This program is to practice static class, which SHOULD be called without instantiating it.
using System;

static class test_call {
	public static void call () { //Seems in static class, the methods have to be in static.
		Console.WriteLine ("This is call () function.");
	}
}

class run {
	static void Main () {
		test_call.call ();

	}
}
	


//======== 4 =========
//This program is to practice call methods outside the parent class.
using System; 

class Test_Rectangle {
	static void Main () {
		Rectangle my_rec;
		//double area;

		//Why need the following step? Not sure.
		my_rec = new Rectangle ();

		my_rec.Set_Sides (2.3, 4.6);
		my_rec.Get_Sides ();
		double area = my_rec.Get_Area ();
		Console.WriteLine ("Area = {0}", area);

	}
}

//It does not matter where the class is written in the program, whether before the 
//class that contains Main() function or after it. Likewise in the class, the order of 
//different members or methods are written are not matter. But the order of statements
//expressions inside the method does matter, just like a procedure language.
class Rectangle {
	//Length and width
	double length, width;

	//set the length and width
	public void Set_Sides (double my_length, double my_width) {
		length = my_length;
		width = my_width;
	}

	//Print out the length and width of the rectangle
	public void Get_Sides () {
		Console.WriteLine ("{0}Length = {1}", "I. ", length);
		Console.WriteLine ("{0}Width = {1}", "II. ", width);
	}

	public double Get_Area () {
		
		return length * width;
	}
}
	


//======== 3 ==========
//This program is to test what components a program should include at least: the Main()
//function which is included in a class. So a c# program should at least include a class
//and a Main() method inside the class.
using System;

class test_class {
	public void test () { //public is required as it's called outside of the class
								  //static is not required, but the place where the method
							      //is called will use reference (which I'm not sure how).
		Console.WriteLine ("hi");
	}

	public static void static_test () {

		Console.WriteLine ("Static test method is called.");
	}
}

class call_test {
	static void Main () {
		//since the Main () method is static, so it can not directly call a non-static
		//method, it has to instantiate the class with an object, which can call the method.
		test_class my_class = new test_class ();
		my_class.test ();

		//Or we can change the method being called to static, and call the method directly.
		test_class.static_test ();
	}
}




//======= 2 ============
//This program is to test ReadKey () and ReadLine() methods.
using System;

namespace test_key_line_app {
	class test_key_line {
		static void Main (string[] args) {
			Console.WriteLine ("ReadLine");
			Console.ReadLine ();

			Console.WriteLine ("ReadKey");
			Console.ReadKey ();

			//Not sure what the difference by now, but here they both serve as a deay of 
			//closing the window.
		}

	}
}


//============ 1 =============
//This is the first c# program for me to understand the components.

using System; //This is to include the classes in namespace System, which contains the 
			  //Class Console and its methods WriteLine() and ReadKey().

//Declare a namespace which contains class HelloWorld.
namespace HelloWorldApplication {
	class HelloWorld {
		//The method in class HelloWorld.
		static void Main (string[] args) {
			Console.WriteLine ("I'm a newbie of c#");
			//ReadKey() waites for a key press so that the screen is not running and closing
			//very quickly.
			Console.ReadKey ();
		}
	}
}
*/
