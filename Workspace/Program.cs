
using Business.Concretes;
using Entities.Concretes;

Console.WriteLine("Hello, World!");









PttManager pttManager=new(new PersonManager());
pttManager.GiveMask(new Person() { FirstName="mahmut",LastName="kabak",DateOfBirthYear=2000,NationalIdentity=25844575120});