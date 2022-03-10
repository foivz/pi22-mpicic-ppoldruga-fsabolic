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

## Tehnologije i oprema
- Visual Studio 2022
- MySQL, MySQL Workbench 
- GitHub
- Draw.io
- Word
