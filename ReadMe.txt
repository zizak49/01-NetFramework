Hello World
===========

Jednostavni primjer za pregled u IL Disassembleru, da se vidi što je sve u modulu.


ConfigurationFile
=================

Ilustrira kako se pomoæu konfiguracijske datoteke App.config (koju prevoditelj 
automatski preimenuje u ConfigurationFile.exe.config i preslika u izvedbeno 
kazalo) može odrediti koja æe se verzija .NET okruženja koristiti tijekom 
izvoðenja. 
Ako .config datoteke nema, pokrenut æe se .NET okruženje za koje je aplikacija
generirana; ako nema te verzije, traži se najviša verzija, veæa od ciljane.

NAPOMENA: .NET 3.0 i .NET 3.5 aplikacije se pokreæe s CLR 2.0.50727.


ClsCompliant1 i ClsCompliant2
=============================
Primjer znaèenja CLS compliant atributa

Sastoji se od dva modula:

1. ClsCompliant1 jest EXE pisan u VB.NET-u koji korisit modul ClsCompliant2

2. ClsCompliant2 jest DLL pisan u C# koji u sebi sadrži klasu TimeProvider sa 
   statièkim metodama:
   - Getdatetime(string ime)
   - GetDateTime()
   - GetDatetime()

   Druga i treæa verzija metoda ne zadovoljavaju CLS, jer se nazivi razlikuju 
   samo po velikim/malim slovima.


VersionsExe i VersionsDLL
=========================
Primjer strogog verzioniranja.

Projek VersionsExe koristi VersionsDLL, koji je "potpisan" sigurnosnim kljuèem.
Promijenimo li verziju DLL-a, a Exe ne prevedemo ponovno za tu novu verziju,
VersionsExe æe se srušiti (baciti iznimku).


Izbjegavanje koda
=================

Buduæi da prilikom izvoðenja programa JIT prevoditelj kôd prevodi u strojni jezik 
metodu po metodu, moguæe je sprijeèiti izvoðenje ako se program izvodi pod
neodgovarajuæom verzijom .NET okruženja.
MetodaKojuPozivamo() provjerava je li verzija CLR-a veæa od 3.5 i samo u tom
sluèaju poziva metodu MetodaKojuŽelimoIzbjeæi(). (verziju CLR-a možemo 
kontrolirati pomoæu konfiguracijske datoteke).