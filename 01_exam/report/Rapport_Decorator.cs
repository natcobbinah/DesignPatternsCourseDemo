using System;
public abstract class RapportDecorator : IRapport
{
    protected IRapport rapport;

    public RapportDecorator(IRapport rapport)
    {
        this.rapport = rapport;
    }

    public virtual string GetContenu()
    {
        return rapport.GetContenu();
    }

    public virtual string GetAuteur()
    {
        return rapport.GetAuteur();
    }
}
