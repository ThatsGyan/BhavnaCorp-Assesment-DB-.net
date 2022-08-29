// See https://aka.ms/new-console-template for more information

using Hospital_Management;
using System.Linq.Expressions;


static void Main(string[] args)
{

    Console.WriteLine("Hello and Welcome to Bhavna Sewa Hospital");
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine();

    string passwordKey = "123@gyan";
    exitlable:
    Console.WriteLine("Enter Your Username : ");
    string username = Console.ReadLine();
    Console.WriteLine("Enter Password : ");
    string password = Console.ReadLine();

    if (password != passwordKey)
    {
        Console.WriteLine("Your password is incorrect , Please Try Again : ");
        goto exitlable;
    }
    else
    {
        Console.WriteLine("Login Sucessfull");
        Console.WriteLine("\n\n\n\n Select any for / register doctors, register patients, book bed for patient");
        Console.WriteLine();
        Console.WriteLine("Press \"A\" for Doctor Registration, Press \"B\" for patients Registration, Press \"C\" for Book Bed ");
        string A = Console.ReadLine();

        switch (A)
        {
            case "A":

                Console.WriteLine("<------------------------------Enter Doctor Registration Details------------------------------");
                Console.WriteLine("Enter Doctor ID : ");
                string doctorID = Console.ReadLine();
                Console.WriteLine("Enter Doctor Name : ");
                string doctorName = Console.ReadLine();
                Console.WriteLine("Enter Doctor Speciality : ");
                string doctorSpecialty = Console.ReadLine();
                Console.WriteLine("Enter Doctor Contact Number : ");
                int doctorContact = int.Parse(Console.ReadLine());

                Console.WriteLine("Details are sucessfully Registerd :  \n\n\n");
                Console.WriteLine("ID : " + doctorID + "\nName :  " + "\nSpecialty : " + doctorSpecialty + "\nContact Number : " + doctorContact);




                break;
            case "B":
                Console.WriteLine("<------------------------------Enter Patients Registration Details------------------------------");
                Console.WriteLine("Enter patient ID : ");
                string PatientID = Console.ReadLine();
                Console.WriteLine("Enter patient Name : ");
                string PatientName = Console.ReadLine();
                Console.WriteLine("Enter patient disease : ");
                string PatientDisease = Console.ReadLine();
                Console.WriteLine("Enter patient Contact Number : ");
                int patientContact = int.Parse(Console.ReadLine());
                Console.WriteLine("Details are sucessfully Registerd :  \n\n\n");
                Console.WriteLine("Patient ID : " + PatientID + "\nPatient Name : " + PatientName + "\nPatient Disease" + PatientDisease + "Patient Cintact Number : " + patientContact);

                break;

            case "C":
                Console.WriteLine("<------------------------------Book A Bed------------------------------");
                Console.WriteLine("Enter wing Number");
                string wingNumber = Console.ReadLine();

                Console.WriteLine("Enter Floor Number");
                string floorNumber = Console.ReadLine();

                Console.WriteLine("Enter bed Number");
                int bedNumber = int.Parse(Console.ReadLine());
                Console.WriteLine("Details are sucessfully Registerd :  \n\n\n");
                Console.WriteLine("\nWing Number : " + wingNumber + "\nFloor :  " + floorNumber + "\nBed Number : " + bedNumber);
                break;
            default:
                Console.WriteLine("Please Enter A Valid INPUT");
                break;//
        }
    }


    //Switch case//
    

    




}







