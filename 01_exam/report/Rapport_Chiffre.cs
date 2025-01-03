using System;
public class RapportChiffre : RapportDecorator
{
    public RapportChiffre(IRapport rapport) : base(rapport) { }

    public override string GetContenu()
    {
        return Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(rapport.GetContenu()));
    }
}

