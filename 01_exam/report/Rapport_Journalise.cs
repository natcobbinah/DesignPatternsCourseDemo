using System;

public class RapportJournalise : RapportDecorator
{
    public RapportJournalise(IRapport rapport) : base(rapport) { }

    public override string GetContenu()
    {
        string contenu = rapport.GetContenu();
        Console.WriteLine($"[LOG] Accès au rapport à {DateTime.Now}");
        return contenu;
    }
}
