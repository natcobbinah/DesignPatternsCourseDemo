public class ParticulierFactory : DocumentBancaireFactory
{
    public override IBancaireRIB CreateRIB()
    {
        return new RIBParticulier();
    }

    public override IBancaireAttestation CreateAttestation()
    {
        return new AttestationParticulier();
    }

    public override IAttestationFiscale createTaxFile()
    {
        return new FiscaleParticulier();
    }
}