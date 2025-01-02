class Program
{
    static void Main(string[] args)
    {
        // Test avec un client particulier
        DocumentBancaireFactory factoryParticulier = new ParticulierFactory();
        IBancaireRIB ribParticulier = factoryParticulier.CreateRIB();
        IBancaireAttestation attestationParticulier = factoryParticulier.CreateAttestation();
        IAttestationFiscale attestationFiscale = factoryParticulier.createTaxFile();

        Console.WriteLine(ribParticulier.GenererRIB());
        Console.WriteLine(attestationParticulier.GenererAttestation());
        Console.WriteLine(attestationFiscale.GenererAttestationFiscale());

        // Test avec un client professionnel
        DocumentBancaireFactory factoryProfessionnel = new ProfessionnelFactory();
        IBancaireRIB ribProfessionnel = factoryProfessionnel.CreateRIB();
        IBancaireAttestation attestationProfessionnel = factoryProfessionnel.CreateAttestation();
        IAttestationFiscale attestationProfessional = factoryProfessionnel.createTaxFile();

        Console.WriteLine(ribProfessionnel.GenererRIB());
        Console.WriteLine(attestationProfessionnel.GenererAttestation());
        Console.WriteLine(attestationProfessional.GenererAttestationFiscale());
    }
}