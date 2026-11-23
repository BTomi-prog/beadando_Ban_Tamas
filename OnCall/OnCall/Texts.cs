namespace OnCall
{
    // Kész szövegek a játékhoz. Szabadon használhatod, bővítheted és átírhatod őket.
    // Véletlen elem egy tömbből: Texts.X[random.Next(Texts.X.Length)]
    internal static class Texts
    {
        public const string Title = @"
  ___           ____      _ _
 / _ \ _ __    / ___|__ _| | |
| | | | '_ \  | |   / _` | | |
| |_| | | | | | |__| (_| | | |
 \___/|_| |_|  \____\__,_|_|_|
";

        public const string Intro =
            "Hétfő reggel 8 óra. Te vagy a Kockás Kft. egyetlen rendszergazdája,\n" +
            "és ezen a héten nálad van az ügyeleti telefon. Óránként érkeznek a jegyek:\n" +
            "nem nyomtat a nyomtató, leállt a webshop, valaki elfelejtette a jelszavát.\n" +
            "Mindent nem tudsz egyszerre megcsinálni. Ha a jegyek határideje lejár,\n" +
            "a kollégák elégedetlenek lesznek, és ha elfogy a türelmük, kirúgnak.\n" +
            "Bírd ki péntek délután 4-ig!";

        // ---- Jegyek (K3) ----
        public static readonly string[] LowTickets =
        {
            "Új egér kell",
            "Nem működik a webkamera",
            "Lassan nyílik egy mappa",
            "Új billentyűzet kell",
            "Eltűnt egy ikon",
            "Új háttérképet kér a főnök",
            "Recseg a hangszóró",
        };

        public static readonly string[] NormalTickets =
        {
            "Nem nyomtat a nyomtató",
            "Elfelejtett jelszó",
            "Nem jönnek meg a levelek",
            "Nem indul a táblázatkezelő",
            "Nem látszik a közös mappa",
            "Lefagy a könyvelőprogram",
            "Nem megy a második monitor",
        };

        public static readonly string[] HighTickets =
        {
            "Nem működik a VPN",
            "Betelt a szerver lemeze",
            "Nem érhető el a CRM",
            "Nincs wifi a tárgyalóban",
            "Lejárt egy tanúsítvány",
        };

        public static readonly string[] CriticalTickets =
        {
            "Leállt a webshop",
            "Nem lehet bejelentkezni",
            "Leállt a pénztárrendszer",
            "Leállt a telefonközpont",
        };

        // ---- Munka (K4) ----
        public static readonly string[] WorkTexts =
        {
            "Átnézted a naplófájlokat.",
            "Újraindítottad a szolgáltatást.",
            "Telefonon végigvezetted a kollégát a lépéseken.",
            "Frissítetted az illesztőprogramot.",
            "Rákerestél a hibaüzenetre.",
            "Kicserélted a kábelt.",
        };

        public static readonly string[] DoneTexts =
        {
            "A kolléga megköszönte a gyors segítséget.",
            "Minden működik, lezártad a jegyet.",
            "Kipróbáltátok együtt, már jó.",
            "A kolléga kávét hozott neked hálából.",
        };

        public static readonly string[] CoffeeTexts =
        {
            "Megittál egy kávét a konyhában.",
            "Elolvastad a céges hírlevelet.",
            "Rendet raktál az asztalodon.",
            "Kinéztél az ablakon, és vettél egy mély levegőt.",
        };

        // ---- Határidők (K5) ----
        public static readonly string[] LateTexts =
        {
            "Csörög a telefon: a kollégák türelmetlenek.",
            "A főnököd megkérdezte, mikor lesz kész a lejárt jegy.",
            "Valaki panaszt írt a lejárt jegy miatt.",
        };

        // ---- A hét vége (K6) ----
        public const string RatingExcellent = "Kiváló hét! A főnököd megdicsért a heti megbeszélésen.";
        public const string RatingPassed = "Túlélted a hetet. Nem volt tökéletes, de a cég működik.";
        public const string RatingProbation = "Épphogy túlélted. A főnököd meghosszabbította a próbaidődet.";
        public const string Fired = "Elfogyott a kollégák türelme. A főnököd behívott az irodájába... Game Over.";
        public const string QuitText = "Leadtad az ügyeleti telefont.";

        // ---- Gyakornok (A1) ----
        public static readonly string[] InternTexts =
        {
            "A gyakornok lelkesen nekiállt.",
            "A gyakornok a kolléga mellett ülve próbálja megoldani.",
            "A gyakornok jegyzetel, és lassan halad.",
        };

        public const string InternDone = "A gyakornok büszkén jelentette, hogy lezárta a jegyet.";

        // ---- Napi riport (A2) ----
        public const string GoodDay = "Jó nap volt, a kollégák elégedettek.";
        public const string BadDay = "Nehéz nap volt, holnap jobban kell figyelni a határidőkre.";

        // ---- Szerverek (A3) ----
        public static readonly string[] ServerProblems =
        {
            "hibát jelez",
            "lassan válaszol",
            "magától újraindult",
            "túlmelegedett",
        };

        public static readonly string[] MaintenanceTexts =
        {
            "Frissítéseket telepítettél.",
            "Kitakarítottad a régi naplófájlokat.",
            "Kicserélted a zajos ventilátort.",
            "Ellenőrizted a biztonsági mentést.",
        };

        // ---- Jegytípusok (N1) ----
        public static readonly string[] HardwareTickets =
        {
            "Nem kapcsol be a laptop",
            "Megrepedt a monitor",
            "Kattog a merevlemez",
        };

        public static readonly string[] VirusTickets =
        {
            "Gyanús csatolmány",
            "Furcsa felugró ablakok",
            "Titkosított fájlok",
        };

        public static readonly string[] ServerDownTickets =
        {
            "Nem válaszol a fájlszerver",
            "Leállt az adatbázis",
            "Nem megy a levelezőszerver",
        };

        public const string PartOrdered = "Kiderült, hogy alkatrész kell. Megrendelted.";
        public const string PartArrived = "Megérkezett az alkatrész.";
        public const string VirusSpread = "A vírus továbbterjedt egy másik gépre!";

        // ---- Automatizálás (N2) ----
        public const string PortalSolved = "Egy kolléga a jelszóportálon maga oldotta meg a problémáját.";
        public const string ScriptReady = "Elkészült a szkript, mostantól magától fut.";

        // ---- Szakember-típus (N3) ----
        public const string VeteranText = "Veterán: már mindent láttál, a Normál és Magas jegyek gyorsabban mennek.";
        public const string FirefighterText = "Tűzoltó: vészhelyzetben vagy a legjobb, a Kritikus jegyek dupla jutalmat érnek.";
        public const string NightOwlText = "Éjszakás: este is szívesen maradsz, naponta 2 óra túlórát vállalhatsz.";

        // ---- Nagy leállás (N4) ----
        public const string OutageStart = "Elsötétültek a monitorok: leállt a teljes hálózat!";
        public const string OutageEnd = "Újra működik a hálózat. A közben beérkezett jegyek most jelennek meg.";

        public static readonly string[] OutageTexts =
        {
            "Végigjártad a szerverszobát.",
            "Megtaláltad a hibás switch-et.",
            "Átkábelezted a rack-et.",
            "Egyesével ellenőrizted a kapcsolatokat.",
        };
    }
}
