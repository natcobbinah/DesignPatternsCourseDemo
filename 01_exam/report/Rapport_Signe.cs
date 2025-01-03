using System;
public class RapportSigne : RapportDecorator
{
    public RapportSigne(IRapport rapport) : base(rapport) { }

    public override string GetContenu()
    {
        return rapport.GetContenu() + $"\nSigné par: {rapport.GetAuteur()}";
    }
}
