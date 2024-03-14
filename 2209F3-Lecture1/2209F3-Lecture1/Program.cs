// See https://aka.ms/new-console-template for more information
/*Console.WriteLine("Hello, World!");
Console.WriteLine("This is John\"s Pen");

int a;
a = 123;
string b = "Usama";
bool c = true;
double d = 2.2;
decimal e = 2;
float f = 3;
string g = "2f";
char h = '%';
long l = 324345344334;
Console.WriteLine(a);
Console.WriteLine(b);
Console.WriteLine(c);
Console.WriteLine(d);
Console.WriteLine(e);
Console.WriteLine(f);
Console.WriteLine(g);
Console.WriteLine(h);
Console.WriteLine(l);

var m = "hjfkjdskfjds";
Console.WriteLine(m);

const double pi = 3.14159265359;
Console.WriteLine(pi);

Console.WriteLine($"Hello {b} :-{{");
*/


/*
string name = "Usama";

Console.WriteLine($"Welcome back! {name} fhjhdsjhfjsd {name} jfkdsjkfjsd {name}");
*/

//Type Casting

//String a = "43453";

//int b = Convert.ToInt32(a);
//String a = "false";

//bool b = Convert.ToBoolean(a);

/*
int a = 345345;

string b = Convert.ToString(a);

Console.WriteLine($"Value: {b} Type: {b.GetType()}");
*/


/*double num1 = 34;

double num2 = 35;

Console.WriteLine(num1 + num2);
Console.WriteLine(num1 - num2);
Console.WriteLine(num1 * num2);
Console.WriteLine(num1 / num2);
Console.WriteLine(num1 % num2);

*/



//Math Class

/*
int a = -34;

//Console.WriteLine(Math.Sqrt(a));
//Console.WriteLine(Math.Pow(a,4));
//Console.WriteLine(Math.Abs(a));
Console.WriteLine(Math.Max(2,4));
Console.WriteLine(Math.Min(2,4));
Console.WriteLine(Math.Round(3.54));
Console.WriteLine(Math.Ceiling(3.1));
Console.WriteLine(Math.Floor(3.9));


*/


/*
Random random = new Random();


Console.WriteLine(random.Next(1,101));
Console.WriteLine(random.NextDouble());

*/




//string a = "Hello How are You";

//string b = a.ToUpper();
//string b = a.ToLower();
//string b = a.Replace("H","Tfsda");
//string b = a.Insert(5," John");
//string b = a.Substring(10,3);




//Console.WriteLine(a.Length);


//int age = 79;
/*
if(age >= 18)
{
    Console.WriteLine("You are below 18");
}
else
{
    Console.WriteLine("You are not suitable for our Website");
}

*/
/*
if (age == 0)
{
    Console.WriteLine("You are not born");
}
else if(age > 70)
{
    Console.WriteLine("You are going to die soon InshaAllah");
}
else if(age == 18)
{
    Console.WriteLine("Congratulation! You are 18");

}else if(age < 18)
{
    Console.WriteLine("You are below 18");

}
else if(age > 18)
{
   
    Console.WriteLine("You are above 18");
}
*/

/*

Console.WriteLine("Enter the number of your day: ");
string day = Console.ReadLine();

switch (day)
{
    case "1":
        Console.WriteLine("Today is Monday!");
        break;
    case "2":
        Console.WriteLine("Today is Tuesday");
        break;
    case "3":
        Console.WriteLine("Today is Wednesday");
        break;
    case "4":
        Console.WriteLine("Today is Thursday");
        break;
    case "5":
        Console.WriteLine("Today is Friday");
        break;
    case "6":
        Console.WriteLine("Today is Saturday");
        break;
    case "7":
        Console.WriteLine("Today is Sunday");
        break;
} 

*/


//Logical Operator

/*
int age = 87;

if(age > 18 || age < 70)
{
    Console.WriteLine("You are above 18");
}
else if(age < 18 && age > 0)
{
    Console.WriteLine("You are below 18");
}
else
{
    Console.WriteLine("You are not alive!");
}

*/

/*
Console.Write("Enter your Name : ");

string name = Console.ReadLine();


while (name == "")
{
    Console.Write("Enter your Name : ");

    name = Console.ReadLine();
}

Console.WriteLine($"Hello {name}!");
*/



//int a = 1;
/*
Console.WriteLine("Enter your max limit to print Numbers: ");
int b = Convert.ToInt32(Console.ReadLine());

while(a <= b)
{
    Console.WriteLine(a);
    a++;
}
*/

/*

for(;a<= 10; a++)
{
    Console.WriteLine(a);
}


*/


/*


for (int i = 0; i < 5; i++)
{
    Console.WriteLine("");
    for (int j = 0; j < 10; j++)
    {
        Console.WriteLine(j);
    }
}

*/

//string a = Console.ReadLine();

//string[] numbers = { "Arif","Ali","Zahid" };
//int[,] numbers = { { 2,4 },{5,6 },{7,8 } };



//Console.WriteLine(numbers);

/*
for (int i = 0; i < numbers.Length; i++)
{
    for (int j = 0; j < 2; j++)
    {
        Console.WriteLine(numbers[i,j]);
    }
}
*/

/*
foreach (int number in numbers)
{
        Console.WriteLine(number);
}

*/



//int[,] numbers = 
//{
//    {1,3,5,7,8},
//    {2,4,6,9,13}
//};

//int[][] nums = new int[6][];

//nums[0] =  [ 1,3,5,6 ];
//nums[1] = [ 2,4,5,6 ];
//nums[2] = [ 4,5,6,7,9 ];
//nums[3] = [ 2,4,7,9,0 ];
//nums[4] = [ 10,90,87,65,89,97,56,45 ];
//nums[5] = [ 1,2,3,4,5,7,8,9,10,11];

//foreach (var number in nums)
//{
//    foreach (var item in number)
//    {
//        Console.WriteLine(item);
//    }
//    Console.WriteLine("--------------------------");
//}


//List<int> nums = new List<int>();

//nums.Add(1);
//nums.Add(2);
//nums.Add(14);
//nums.Add(6);
//nums.Add(27);
//nums.Add(8);
//nums.Add(19);



//Console.WriteLine("before sorting");


//nums.Reverse();


//foreach (int i in nums)
//{
//    Console.WriteLine(i);
//}

//Console.WriteLine(nums[3]);

//nums.Remove(8);

//nums.IndexOf(8);
//Console.WriteLine("Index of 8: "+nums.IndexOf(8));

//nums.Insert(5, 2000);
//nums.Sort();

//Console.WriteLine($"Total Count of list is: {nums.Count}");
//Console.WriteLine($"Last Index: {nums.LastIndexOf(19)}");
//Console.WriteLine($"Contains: {nums.Contains(19)}");
//Console.WriteLine($"Sort: ");

//nums.Reverse();

//Console.WriteLine("After sorting");
////nums.Clear();
//foreach (int i in nums)
//{
//    Console.WriteLine("nums list: " + i);
//}


//int[] numbers = nums.ToArray();

//Console.WriteLine("numbers: "+numbers);
//Console.WriteLine("list: "+nums);

//foreach(int n in numbers)
//{
//    Console.WriteLine("numbers array: "+n);
//}


using gamespace;


//Game GTA = new Game();
//Game superMario = new Game();

//GTA.name = "GTA 7";
//GTA.company = "Rockstar";
//GTA.releaseDate = "2027";
//GTA.rating = 4.5;

//Console.WriteLine(GTA.name);


//superMario.name = "Super Mario Bros. Wonder";
//superMario.company = "Nintendo";
//superMario.releaseDate = "2023";
//superMario.rating = 4.7;


//Console.WriteLine($"Super Mario Company: {superMario.company}");




//Game supermario = new()
//{
//    name = "Super Mario 7",
//    company = "Nintendo",
//    releaseDate = "02-03-2025",
//    rating = 4.0,
//};


//Console.WriteLine(supermario.name);
//Console.WriteLine(supermario.company);


//Game supermario = new Game("Super Mario 7", "Nintendo", "02-03-2025", 4.5);

//Game GTA = new Game("GTA 7");

//supermario.name = "Assassin Creed";

//Game CoD = new Game(gameRating:3.4, gameCompany:"Activision", gameReleaseDate:"03-05-2025", gameName:"Call of Duty 6");


//Console.WriteLine(supermario.name);
//Console.WriteLine(GTA.name);
//Console.WriteLine("The Game Name :{0} and the company is:{1} and its release Date:{2} and its rating is: {3}",
//    CoD.name,CoD.company,CoD.releaseDate,CoD.rating);
//Console.WriteLine($"The Game Name :{CoD.name} and the company is:{CoD.company} and its " +
//    $"release Date:{CoD.releaseDate} and its rating is: {CoD.rating}");
//Console.WriteLine(supermario.company);


//Game hobo = new Game("Hobo 5", "Fully", "09-07-2024", 5.0);

//Console.WriteLine(hobo.name);
//Console.WriteLine(hobo.rating);

//supermario.isGameAvailable("nohjhsadfjh");


//Game.isWebsiteDown("fjdskfj");

Nintendo supermario = new()
{
    gameName = "Super mario 7",
    company = "Nintendo.org"
};

Console.WriteLine(supermario.gameName);

supermario.gameDesc();


Ubisoft farCry = new()
{
    gameName = "Far Cry 3",
    gameVersion = "4.5",
    company = "Ubisoft"

};

farCry.gameDesc();

Console.WriteLine(farCry.ToString());


Nintendo cod = new()
{
    gameName = "Call of Duty 7",
   

};

cod.setUserLoginId("73824875892347785");

Console.WriteLine(cod.printUserLoginId());

//Console.WriteLine(cod.uPassword());



Console.ReadKey();

namespace gamespace
{
    //class Game
    //{
    //    public string name { get; set; }
    //    public string company;
    //    public string releaseDate;
    //    public double rating;



    //    public Game(string gameName, string gameCompany, string gameReleaseDate, double gameRating)
    //    {
    //        this.name = gameName;
    //        this.company = gameCompany;
    //        this.releaseDate = gameReleaseDate;
    //        this.rating = gameRating;

    //    }

    //    public Game(string gameName, string gameCompany, string gameReleaseDate)
    //    {
    //        this.name = gameName;
    //        this.company = gameCompany;
    //        this.releaseDate = gameReleaseDate;

    //    }
    //    public Game(string gameName, string gameCompany)
    //    {
    //        this.name = gameName;
    //        this.company = gameCompany;
    //    }
    //    public Game(string gameName)
    //    {
    //        this.name = gameName;

    //    }


    //    public void isGameAvailable(string value)
    //    {
    //        if(value == "yes")
    //        {
    //            Console.WriteLine("The game is available");
    //        }
    //        else if(value == "no")
    //        {
    //            Console.WriteLine("The game is not available");
    //        }
    //        else
    //        {
    //            Console.WriteLine("You have entered wrong value");
    //        }
    //    }


    //    public static void isWebsiteDown(string value)
    //    {
    //        if (value == "yes")
    //        {
    //            Console.WriteLine("The website is down due to some issues");
    //        }
    //        else if (value == "no")
    //        {
    //            Console.WriteLine("The website is available download your fav. games");
    //        }
    //        else
    //        {
    //            Console.WriteLine("You have entered wrong value");
    //        }
    //    }






    //}









    abstract class Game
    {
        public string gameName;
        public string gameVersion;
        public string company;
        private string userPassword;
        protected string userLoginId;


        public virtual void gameDesc() { }

        public void passwordReset(string newPassword){
            this.userPassword = newPassword;
        }
        //public string uPassword()
        //{
        //    return this.userPassword;
        //}

    }


    class Nintendo : Game
    {
        
        public override void gameDesc()
        {
            Console.WriteLine($"Game name {this.gameName} and Company name {this.company}");
        }

        public void setUserLoginId(string userId)
        {
            this.userLoginId = userId;
        }
        public string printUserLoginId()
        {
            return this.userLoginId;
        }

    }


    class Ubisoft : Game
    {

        public override void gameDesc()
        {
            Console.WriteLine($"Game name {this.gameName} and Company name {this.company} and its version is {this.gameVersion}");
            base.gameDesc();
        }



        public override string ToString()
        {
            return $"Game Name: {this.gameName} \n Company Name: {this.company} \n Game Version: {this.gameVersion} \n User Login Id: {this.userLoginId} ";
        }



    }














}







Audionic headphone = new()
{
    productName = "Headphone Simple v1",
    productPrice = 3400,
    productRatting = 3.3
};



Audionic speaker = new()
{
    productName = "Speaker Simple v1",
    productPrice = 15000,
    productRatting = 5.0
};




HudaBeauty lipstick = new()
{
    productName = "Lipstick Achi",
    productPrice = 200,
    productRatting = 1.0,
    color1 = "Red",
    color2 = "Baby Pink",
    color3 = "Magenda",
    color4 = "Blue"
};


Console.WriteLine($"\nAudionic : \n\n{headphone.prodDesc()} {speaker.prodDesc()}");

Console.WriteLine($"Sales Price: {headphone.prodPrice()}");
Console.WriteLine($"Sales Price: {speaker.prodPrice()}");

Console.WriteLine($"\nHudaBeauty: \n\n{lipstick.prodDesc()}");

Console.WriteLine($"colors: {lipstick.colorsVariety()}");
Console.WriteLine($"Sales Price: {lipstick.prodPrice()}");





interface IElectronics
{
    string prodDesc();
    double prodPrice();
}

interface ICosmetics
{
    string colorsVariety();
}

class Audionic : IElectronics
{
    public string productName;
    public double productRatting;
    public double productPrice;
    public string prodDesc() {
        return $"\nProduct Name: {this.productName} \nProduct Ratting: {this.productRatting} \nGross Price: {this.productPrice}";
    }
    public double prodPrice()
    {
        return this.productPrice + 10;
    }
}

class HudaBeauty : IElectronics, ICosmetics
{
    public string productName;
    public double productRatting;
    public double productPrice;
    public string color1;
    public string color2;
    public string color3;
    public string color4;
    public string prodDesc()
    {
        return $"\nProduct Name: {this.productName} \nProduct Ratting: {this.productRatting} \nGross Price: {this.productPrice}";
    }
    public double prodPrice()
    {
        return this.productPrice + 10;
    }

    public string colorsVariety() 
    {
        return $"{this.color1}, {this.color2}, {this.color3}, {this.color4}";
    }
}















