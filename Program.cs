//APP1
string name;
string surname;
Console.WriteLine("Please enter your name : ");
name = Console.ReadLine();
Console.WriteLine("Please enter your surname : ");
surname = Console.ReadLine();
string nameandsurname = name + " " + surname ;
Console.WriteLine(nameandsurname);

int studentNo;
int studentAge;
long studentId;
int stdbirthyear;
string stdaddress;
Console.WriteLine("Please enter your student number : ");
studentNo = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please enter your Age : ");
studentAge = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please enter your ID : ");
studentId = Convert.ToInt64(Console.ReadLine());
Console.WriteLine("Please enter your birthyear : ");
stdbirthyear = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please enter your Address : ");
stdaddress = Console.ReadLine();

Console.WriteLine(studentNo);
Console.WriteLine(studentId);
Console.WriteLine(stdbirthyear);
Console.WriteLine(studentAge);
Console.WriteLine(stdaddress);
var together1 =  nameandsurname;
var together2 = studentNo +  studentId + stdbirthyear + studentAge +  stdaddress ;

Console.WriteLine (together1);
Console.WriteLine (together2);


//APP2
 
var item1 = 50;
var item2 = 60.5;
var item3 = 356.45;

var sum = item1 + item2 + item3;
Console.WriteLine(sum);