public abstract class DocumentBancaireFactory
{
    public abstract IBancaireRIB CreateRIB();
    public abstract IBancaireAttestation CreateAttestation();

    public abstract IAttestationFiscale createTaxFile();
}