using System;

class Atvalt :
    def __init__(self, szam=None):
        self.szam = szam  # Az inicializált szám (bináris vagy tízes)

    def set_szam(self, szam):
      
        self.szam = szam

    def atvalt(self):
  
        try:
            if all(c in '01' for c in self.szam):  # Ha csak '0' és '1' karakterek vannak benne
                # Bináris -> Tízes
                return str(int(self.szam, 2))
            else:
                # Tízes -> Bináris
                szam_tizes = int(self.szam)
                return bin(szam_tizes)[2:]  # bin() prefixet levágjuk
        except ValueError:
            raise ValueError("Hibás adat! A szám vagy nem bináris, vagy nem szám.")

    def get_eredmeny(self):
        
        return self.szam
