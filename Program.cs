﻿using System;
using System.Collections.Generic;

enum Genders { Male, Female }
class Member
{

    public string FirstName { get; set; }
    public string LastName { get; set; }
    public Genders Gender { get; set; }
    public DateTime Birthday { get; set; }
    public string PhoneNumber { get; set; }
    public int Age { get; set; }
    public string BirthPlace { get; set; }
    public bool IsGraduated { get; set; }



    public string GetName()
    {
        return LastName + " " + FirstName;
    }
    public string getInfor()
    {
        if (IsGraduated)
        {
            return LastName + " " + FirstName + "-" + Gender + "-" + PhoneNumber + "-" + Birthday.ToString("MM/dd/yyyy") + "-" + Age + "-" + "Graduated";
        }
        else
        {
            return LastName + " " + FirstName + "-" + Gender + "-" + PhoneNumber + "-" + Birthday.ToString("MM/dd/yyyy") + "-" + Age + "-" + "Not Graduate";
        }
    }


}

namespace Assignment_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Tao Data
            List<Member> members = new List<Member>();
            members.Add(new Member() { FirstName = "Frederick ", LastName = "Lamb", Gender = Genders.Male, PhoneNumber = "(815) 589-4870", Birthday = DateTime.Parse("3/22/1998"), Age = 24, BirthPlace = "Hanoi", IsGraduated = true });
            members.Add(new Member() { FirstName = "Walter ", LastName = "Weaver", Gender = Genders.Female, PhoneNumber = "(660) 339-7988", Birthday = DateTime.Parse("05/10/2002"), Age = 20, BirthPlace = "Hai Phong", IsGraduated = false });
            members.Add(new Member() { FirstName = "Damari  ", LastName = "Joseph", Gender = Genders.Male, PhoneNumber = "(606) 768-4124", Birthday = DateTime.Parse("04/19/1996"), Age = 26, BirthPlace = "Nghe An", IsGraduated = false });
            members.Add(new Member() { FirstName = "Lina  ", LastName = "Richardson", Gender = Genders.Female, PhoneNumber = "(808) 689-7184", Birthday = DateTime.Parse("05/17/2000"), Age = 22, BirthPlace = "Ha Tinh", IsGraduated = true });
            members.Add(new Member() { FirstName = "Joslyn  ", LastName = "Glenn", Gender = Genders.Male, PhoneNumber = "(808) 689-7184", Birthday = DateTime.Parse("10/21/1997"), Age = 25, BirthPlace = "Thanh Hoa", IsGraduated = false });
            members.Add(new Member() { FirstName = "Logan ", LastName = "Acosta", Gender = Genders.Female, PhoneNumber = "(315) 676-4483", Birthday = DateTime.Parse("09/29/1999"), Age = 23, BirthPlace = "Quang Binh", IsGraduated = false });
            members.Add(new Member() { FirstName = "Malia  ", LastName = "Saunders", Gender = Genders.Male, PhoneNumber = "(502) 268-0042", Birthday = DateTime.Parse("01/04/2002"), Age = 20, BirthPlace = "HCM", IsGraduated = false });
            members.Add(new Member() { FirstName = "Greta  ", LastName = "Dougherty", Gender = Genders.Female, PhoneNumber = "(630) 365-2842", Birthday = DateTime.Parse("04/19/1998"), Age = 24, BirthPlace = "Nam Dinh", IsGraduated = true });
            members.Add(new Member() { FirstName = "Eleanor  ", LastName = "Shepard", Gender = Genders.Male, PhoneNumber = "(630) 365-2842", Birthday = DateTime.Parse("09/08/2001"), Age = 21, BirthPlace = "Hanoi", IsGraduated = true });
            members.Add(new Member() { FirstName = "Melissa  ", LastName = "Singh", Gender = Genders.Female, PhoneNumber = "(706) 517-0664", Birthday = DateTime.Parse("06/29/1998"), Age = 24, BirthPlace = "Hanoi", IsGraduated = true });
            members.Add(new Member() { FirstName = "Alexa  ", LastName = "Simson", Gender = Genders.Female, PhoneNumber = "(126) 321-321", Birthday = DateTime.Parse("06/29/2000"), Age = 22, BirthPlace = "Hanoi", IsGraduated = true });

            // Lay full name
            Console.WriteLine();
            Console.WriteLine("All members' full name:");
            foreach (Member i in members)
            {

                Console.WriteLine(i.GetName());
            }
            //Cac member la nam
            Console.WriteLine("############################");
            Console.WriteLine("List Male members:");
            foreach (Member i in members)
            {
                if (i.Gender == Genders.Male)
                {
                    Console.WriteLine(i.GetName());
                }
            }
            //Member gia nhat
            Console.WriteLine("############################");
            Console.WriteLine("Oldest person is:");
            Member oldest = members[0];
            for (int i = 0; i < members.Count; i++)
            {
                if (members[i].Age > oldest.Age)
                {
                    oldest = members[i];
                }

            }
            Console.WriteLine(oldest.GetName());

            //Phan loai member theo nam sinh
            Console.WriteLine("############################");
            List<Member> membersIn2000 = new List<Member>();
            List<Member> membersBefore2000 = new List<Member>();
            List<Member> membersAfter2000 = new List<Member>();
            foreach (Member i in members)
            {
                switch (i.Birthday.Year)
                {
                    case int n when n > 2000:
                        membersAfter2000.Add(i);
                        break;
                    case int n when n == 2000:
                        membersIn2000.Add(i);
                        break;
                    case int n when n < 2000:
                        membersBefore2000.Add(i);
                        break;
                }

            }
            Console.WriteLine("Member before 2000:");
            foreach (Member i in membersBefore2000)
            {

                Console.WriteLine(i.getInfor());
            }
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Member In 2000:");
            foreach (Member i in membersIn2000)
            {

                Console.WriteLine(i.getInfor());
            }
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Member In 2000:");
            foreach (Member i in membersAfter2000)
            {

                Console.WriteLine(i.getInfor());
            }


            // Nguoi dau tien trong list sinh o Hanoi
            Console.WriteLine("############################");
            Console.WriteLine("First person born in Hanoi");
            int hn = 0;
            while (members[hn].BirthPlace != "Hanoi")
            {
                hn++;
            }
            Console.WriteLine(members[hn].getInfor());
        }

    }
}
