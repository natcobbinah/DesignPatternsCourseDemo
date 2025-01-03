[![](https://mermaid.ink/img/pako:eNrVVk1vgzAM_Ssop03r-AEIVVpbdept2m4TFy-4bSRIqiQcqrb_fSkfbWggtN0OGxfAPNvvGduwI1SkSCJCM1BqxmAlIU94YI7SEswELXLkegKcApM4B6qF3Aa7CnQ84hi-lJbmwXh8tj5NJYLG98Xk4TFYNO7m1oG8aI1Kg2aC21DL7LjMmaKQ4RFuwWprhT5UJ1vLG0jNaJExlB0y_iJhKZaolEFyzP4HZZtFu0kY1yiXQLHVJa_IUaKsJJguYnw1HNvic0OOdg0ucrXyuHrvS3Mu4YAyI99qztYrvqVAxzB2y9wdyNIwwMtbVF_YIZ5Xv626yL_Jswl54vhDilPDiutdYzw9rexBGI779qyDc3eYC-nYGk3GvnUe75-fe2P7nTzZWssg3ofhRaP7UHbYEleBLybFVxJnGoaK07lfSkLd83CLV1tO5dkzZT5NvRM0qK1jp5Uk3fG50sEajiZJxyj6xHSNWZ8OMiI5yhxYan5WyllMiF5jjgmJzGWKSygynZCEHwwUCi0-tpySSMsCR0SKYrUm0RIyZe6KTWq-b_XPTgPZAP8UIq9Bh2-ZkgXn?type=png)](https://mermaid.live/edit#pako:eNrVVk1vgzAM_Ssop03r-AEIVVpbdept2m4TFy-4bSRIqiQcqrb_fSkfbWggtN0OGxfAPNvvGduwI1SkSCJCM1BqxmAlIU94YI7SEswELXLkegKcApM4B6qF3Aa7CnQ84hi-lJbmwXh8tj5NJYLG98Xk4TFYNO7m1oG8aI1Kg2aC21DL7LjMmaKQ4RFuwWprhT5UJ1vLG0jNaJExlB0y_iJhKZaolEFyzP4HZZtFu0kY1yiXQLHVJa_IUaKsJJguYnw1HNvic0OOdg0ucrXyuHrvS3Mu4YAyI99qztYrvqVAxzB2y9wdyNIwwMtbVF_YIZ5Xv626yL_Jswl54vhDilPDiutdYzw9rexBGI779qyDc3eYC-nYGk3GvnUe75-fe2P7nTzZWssg3ofhRaP7UHbYEleBLybFVxJnGoaK07lfSkLd83CLV1tO5dkzZT5NvRM0qK1jp5Uk3fG50sEajiZJxyj6xHSNWZ8OMiI5yhxYan5WyllMiF5jjgmJzGWKSygynZCEHwwUCi0-tpySSMsCR0SKYrUm0RIyZe6KTWq-b_XPTgPZAP8UIq9Bh2-ZkgXn)


classDiagram
    class DocumentBancaireFactory {
        <<abstract>>
        +CreateRIB() IBancaireRIB
        +CreateAttestation() IBancaireAttestation
        +CreateFiscale() IAttestationFiscale
    }
    
    class ParticulierFactory {
        +CreateRIB() IBancaireRIB
        +CreateAttestation() IBancaireAttestation
        +CreateFiscale() IAttestationFiscale
    }
    
    class ProfessionnelFactory {
        +CreateRIB() IBancaireRIB
        +CreateAttestation() IBancaireAttestation
        +CreateFiscale() IAttestationFiscale
    }
    
    class IBancaireRIB {
        <<interface>>
        +GenererRIB() string
    }
    
    class IBancaireAttestation {
        <<interface>>
        +GenererAttestation() string
    }

    class IAttestationFiscale {
        <<interface>>
        +GenererAttestationFiscale() string
    }
    
    class RIBParticulier {
        +GenererRIB() string
    }
    
    class RIBProfessionnel {
        +GenererRIB() string
    }
    
    class AttestationParticulier {
        +GenererAttestation() string
    }
    
    class AttestationProfessionnel {
        +GenererAttestation() string
    }

    class FiscaleParticulier {
        +GenererAttestation() string
    }
    
    class FiscaleProfessionel {
        +GenererAttestation() string
    }

    class Client{

    }

    Client ..> DocumentBancaireFactory
    Client ..> ParticulierFactory
    Client ..> ProfessionnelFactory

    DocumentBancaireFactory <|-- ParticulierFactory
    DocumentBancaireFactory <|-- ProfessionnelFactory

    IBancaireRIB <|.. RIBParticulier
    IBancaireRIB <|.. RIBProfessionnel
   
    RIBParticulier ..> ParticulierFactory
    RIBProfessionnel ..> ProfessionnelFactory

    IBancaireAttestation <|.. AttestationParticulier
    IBancaireAttestation <|.. AttestationProfessionnel

    AttestationParticulier ..> ParticulierFactory
    AttestationProfessionnel ..> ProfessionnelFactory

    IAttestationFiscale <|.. FiscaleParticulier
    IAttestationFiscale <|.. FiscaleProfessionel

    FiscaleParticulier ..> ParticulierFactory
    FiscaleProfessionel ..> ProfessionnelFactory