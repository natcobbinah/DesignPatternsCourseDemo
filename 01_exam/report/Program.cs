using System;

public class Program
{
    static void Main(string[] args)
    {
        IRapport incident = new RapportIncident();
        Console.WriteLine(incident.GetAuteur("normal incident"));
        Console.WriteLine(incident.GetContenu("normal incident content"));
        Console.WriteLine();

        incident = new RapportAnonyme(incident);
        Console.WriteLine(incident.GetAuteur("anonymous incident"));
        Console.WriteLine(incident.GetContenu("anonymous incident content"));
        Console.WriteLine();

        incident = new RapportChiffre(incident);
        Console.WriteLine(incident.GetAuteur("chiffre incident"));
        Console.WriteLine(incident.GetContenu(" chiffre content"));
        Console.WriteLine();

        incident = new RapportSigne(incident);
        Console.WriteLine(incident.GetAuteur("signe incident"));
        Console.WriteLine(incident.GetContenu(" signe content"));
        Console.WriteLine();

        incident = new RapportJournalise(incident);
        Console.WriteLine(incident.GetAuteur("journalise incident"));
        Console.WriteLine(incident.GetContenu(" journalise content"));
        Console.WriteLine();
    }
}
