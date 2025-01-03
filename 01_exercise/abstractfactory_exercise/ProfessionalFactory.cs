public class ProfessionnelFactory : DocumentBancaireFactory
{
    public override IBancaireRIB CreateRIB()
    {
        return new RIBProfessionnel();
    }

    public override IBancaireAttestation CreateAttestation()
    {
        return new AttestationProfessionnel();
    }

    public override IAttestationFiscale createTaxFile()
    {
        return new FiscaleProfessionel();
    }
}