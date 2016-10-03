Hello World
===========

Jednostavni primjer za pregled Visual Studio Solutiona, strukture kazala.
Pregled koda u IL Disassembleru, da se vidi što je sve u modulu.


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

Projekt VersionsExe koristi VersionsDLL, koji je "potpisan" sigurnosnim kljuèem.
Promijenimo li verziju DLL-a, a Exe ne prevedemo ponovno za tu novu verziju,
VersionsExe æe se srušiti (baciti iznimku).
