# Bibly
## Projektni tim

Ime i prezime | E-mail adresa (FOI) | JMBAG | Github korisničko ime
------------  | ------------------- | ----- | ---------------------
Marta Marija Picić | mpicic@foi.hr | 0016142854 | MartaMarija
Patricio Poldrugač | ppoldruga@foi.hr | 0016142508 | ppoldrugac
Fran Sabolić | fsabolic@foi.hr | 0016141404 | fsabolic

## Opis domene
Bibly je aplikacija za lakše rukovanje inventarom knjižnice, ali i za olakšano korištenje usluga knjižnice od strane njenih korisnika. Aplikacija omogućava pregledno pretraživanje željenih knjiga i njihove dostupnosti po danim kriterijima. Pomoću praćenja datuma posuđivanja i rezervacije, Bibly ukazuje korisniku kada knjiga mora biti vraćena ili preuzeta za rezervaciju.
## Specifikacija projekta
Oznaka | Naziv | Kratki opis | Odgovorni član tima
------ | ----- | ----------- | -------------------
F01 | Login | Korisnik, moderator ili administrator se pri ulasku u aplikaciju mora prijaviti koristeći podatke koje je dobio registriranjem u knjižnicu. Ovisno o ulozi, otvara se odgovarajuće sučelje. | Fran Sabolić
F02 | Upravljanje ulogama | Administrator ima mogućnost dodjeljivanja uloga i izmjena prava. Osim toga, administrator može vršiti CRUD operacije nad pripadnicima uloga. | Marta Marija Picić
F03 |Upravljanje općim informacijama |Administrator može mijenjati opće informacije o knjižnici koje se prikazuju svim korisnicima (cjenik, radno vrijeme, adresa, broj telefona… ).| Fran Sabolić
F04 |Upravljanje katalogom |Moderator može pretraživati katalog i vršiti CRUD operacije nad knjigama.| Marta Marija Picić
F05 |Upravljanje korisnicima (dodavanje, brisanje...) |Moderator može dodavati i brisati korisnike te ažurirati njihove podatke.| Patricio Poldrugač
F06 |Upravljanje posudbama i rezervacijama |Prilikom posuđivanja, rezerviranja ili vraćanja knjige od strane korisnika moderator vrši ažuriranje nad stanjima knjiga (npr. skeniranje bar koda knjige). | Marta Marija Picić
F07 |Pregled kataloga |Korisnik može pretraživati knjige po različitim kriterijima (po autoru, nazivu, godini izdanja…). Pritom korisnik može vidjeti dostupnost knjige, opis i ostale podatke o knjizi.| Fran Sabolić
F08 |Dodavanje rezervacije |Prilikom pretraživanja knjige, korisnik ju može rezervirati nakon čega mu se ispisuje datum do kojeg vrijedi rezervacija i kada će biti dostupna ako je već posuđena.| Patricio Poldrugač
F09 |Produljenje posudbe |Korisnik može ograničen broj puta produljiti istu knjigu ukoliko već nije rezervirana.|Fran Sabolić
F10 | Pregled posuđenih i rezerviranih knjiga | Korisnik može vidjeti koliko mu je dana ostalo do povrata posuđene knjige, do kada mu traje rezervacija i kada će određena rezervirana knjiga biti dostupna za preuzimanje.|Patricio Poldrugač


##A
Oznaka|Naziv|Kratki opis|Odgovorni član tima
---|---|---|---
FO1|Prijava|Svaki korisnik se može prijaviti na sustav ako je unesen u bazu podataka, a na temelju uloge korisnika, omogućene su mu odgovarajuće funkcionalnosti sustava.|Patricio Poldrugač
F02|Učlanjivanje|Moderator može dodati korisnika u sustav. Pri dodavanju novog korisnika (člana knjižnice) šalje se verifikacijski mail korisniku s lozinkom i mailom za prijavu na sustav. Osim toga, za korisnika se generira QR kod kako bi se ubrzao rad sa sustavom.|Patricio Poldrugač
FO3|Administriranje bazom podataka|Administrator ima mogućnost unosa, ažuriranja i brisanja nad svim tablicama u bazi podataka. Uz to, administrator može mijenjati tip pojedinog korisnika kako bi mu promijenio prava rada.|Fran Sabolić
FO4|Početna stranica|Pri ulasku u aplikaciju, nakon prijave, korisniku su prikazane najčitanije (najposuđivanije) knjige prošlog mjeseca|Patricio Poldrugač
FO5|Upravljanje profilom|Korisnik može ažurirati podatke svog profila i promijeniti lozinku|Fran Sabolić
FO6|Informacije|Svaki korisnik ima pristup stranici s općim informacijama o radu knjižnice (zakasnina, radno vrijeme, kontakt…). Administrator može mijenjati podatke prikazane na toj stranici.|Patricio Poldrugač
FO7|Katalog knjiga|Svaki korisnik može pristupiti popisu svih knjiga kojeg može pretraživati. Pritiskom na pojedinu knjigu, otvara mu se mogućnost rezervacije ili posudbe dane knjige s prikazom statusa svih primjeraka te knjige (rezervirana, posuđena, dostupna).|Marta Marija Picić
FO8|Korisnikova rezervacija knjiga|Registrirani korisnik može u pregledu pojedine knjige rezervirati određenu knjigu pri čemu navodi datume rezervacije.|Marta Marija Picić
FO9|Korisnikov pregled posudbi i rezervacija knjiga|Korisnik može vidjeti aktivne rezervacije i aktivne i prošle posudbe knjiga. Rezervaciju može otkazati, a posudbe može produljiti i pratiti kasni li s njima i kolika mu je zakasnina.|Marta Marija Picić
F1O|Upravljanje inventarom knjižnice|Moderator ima mogućnost pregledavanja i dodavanja knjige, autora, izdavača, žanra i primjerka pojedine knjige. Osim toga, može ažurirati podatke knjige. Administrator može brisati i ažurirati pojedine autore, izdavače i žanrove. Za svaki primjerak knjige može se generirati Bar kod za ubrzavanje rada u knjižnici.|Patricio Poldrugač
F11|Pregled i upravljanje korisnicima|Moderator i administrator imaju mogućnost pregleda svih korisnika koji su dodani u sustav te mogu ažurirati njihove podatke.|Fran Sabolić
F12|Upravljanje posudbama i rezervacijama|Moderator i administrator mogu pregledati sve trenutne rezervacije i posudbe. Svaku posudbu i rezervaciju mogu unijeti u sustav prilikom čega mogu skenirati bar kod s primjerka knjige i QR kod s kartice člana čime se njihovi podaci unose u formu za posudbu ili rezervaciju. Moderator i administrator mogu izvesti i povrat knjige. Potvrđivanjem rezervacije, stvaraju novu posudbu čime se potvrđena rezervacija uklanja, a unosi se nova posudba.|Marta Marija Picić


## Tehnologije i oprema
- Visual Studio 2022
- MySQL, MySQL Workbench 
- GitHub
- Draw.io
- Word
