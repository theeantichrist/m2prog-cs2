using System;
using System.Collections.Generic;

namespace RijschoolSystem
{
    internal class Auto
    {
        public string Merk { get; set; }
        public string Model { get; set; }
        public string Kenteken { get; set; }

        public Auto(string merk, string model, string kenteken)
        {
            Merk = merk;
            Model = model;
            Kenteken = kenteken;
        }
    }

    internal class RijLeraar
    {
        public string Naam { get; set; }
        public Auto LesAuto { get; set; }

        public RijLeraar(string naam, Auto lesAuto)
        {
            Naam = naam;
            LesAuto = lesAuto;
        }
    }

    internal class Student
    {
        public string Naam { get; set; }
        public LesPakket Pakket { get; set; }

        public Student(string naam, LesPakket pakket)
        {
            Naam = naam;
            Pakket = pakket;
        }
    }

    internal class LesPakket
    {
        public string Naam { get; set; }
        public int AantalLessen { get; set; }
        public decimal Prijs { get; set; }

        public LesPakket(string naam, int aantalLessen, decimal prijs)
        {
            Naam = naam;
            AantalLessen = aantalLessen;
            Prijs = prijs;
        }
    }

    internal class RijTest
    {
        public Student Student { get; set; }
        public RijLeraar Examinator { get; set; }
        public bool Geslaagd { get; set; }

        public RijTest(Student student, RijLeraar examinator, bool geslaagd)
        {
            Student = student;
            Examinator = examinator;
            Geslaagd = geslaagd;
        }
    }

    internal class TheorieTest
    {
        public Student Student { get; set; }
        public int Score { get; set; }
        public bool Geslaagd => Score >= 80;

        public TheorieTest(Student student, int score)
        {
            Student = student;
            Score = score;
        }
    }

    internal class Dag
    {
        public string Naam { get; set; }
        public List<LesUur> LesUren { get; set; } = new List<LesUur>();

        public Dag(string naam)
        {
            Naam = naam;
        }
    }

    internal class LesUur
    {
        public int Uur { get; set; }
        public Student Student { get; set; }
        public RijLeraar Leraar { get; set; }

        public LesUur(int uur, Student student, RijLeraar leraar)
        {
            Uur = uur;
            Student = student;
            Leraar = leraar;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Auto auto = new Auto("Toyota", "Corolla", "AB-123-CD");
            RijLeraar leraar = new RijLeraar("Piet", auto);
            LesPakket pakket = new LesPakket("Starter", 10, 400);
            Student student = new Student("Emma", pakket);

            TheorieTest theorie = new TheorieTest(student, 85);
            RijTest rijtest = new RijTest(student, leraar, true);

            Dag maandag = new Dag("Maandag");
            LesUur uur1 = new LesUur(9, student, leraar);
            maandag.LesUren.Add(uur1);

            Console.WriteLine($"{student.Naam} heeft theorie gehaald: {theorie.Geslaagd}");
            Console.WriteLine($"{student.Naam} heeft praktijk gehaald: {rijtest.Geslaagd}");
            Console.WriteLine($"Les op {maandag.Naam} om {uur1.Uur} uur met leraar {uur1.Leraar.Naam}");
        }
    }
}
