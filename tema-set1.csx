while (true) {
    Console.Write("Alege o optiune (? pt ajutor): ");

    switch (Console.ReadLine()) {
        case "1": T1(); break;
        case "2": T2(); break;
        case "3": T3(); break;
        case "4": T4(); break;
        case "5": T5(); break;
        case "6": T6(); break;
        case "7": T7(); break;
        case "8": T8(); break;
        case "9": T9(); break;
        case "10": T10(); break;
        case "11": T11(); break;
        case "12": T12(); break;
        case "13": T13(); break;
        case "14": T14(); break;
        case "15": T15(); break;
        case "16": T16(); break;
        case "17": T17(); break;
        case "18": T18(); break;
        case "19": T19(); break;
        case "20": T20(); break;
        case "21": T21(); break;
        case "?":
            Console.WriteLine("Optiuni: 1-21");
            break;
        default:
            return 0;
    }

    Console.WriteLine();
}

static void T1() {
    Console.Write("a = ");
    double a = double.Parse(Console.ReadLine());

    Console.Write("b = ");
    double b = double.Parse(Console.ReadLine());

    if (a == 0) {
        if (b == 0) {
            Console.WriteLine("Infinit de solutii");
        }
        else {
            Console.WriteLine("Fara solutie");
        }
    }
    else {
        double solutie = -b / a;
        Console.WriteLine($"x = {solutie}");
    }
}

static void T2() {
    Console.Write("a = ");
    double a = double.Parse(Console.ReadLine());

    Console.Write("b = ");
    double b = double.Parse(Console.ReadLine());

    Console.Write("c = ");
    double c = double.Parse(Console.ReadLine());

    if (a == 0) {
        if (b == 0) {
            Console.WriteLine(c == 0 ? "Infinit de solutii" : "Fara solutie");
        }
        else {
            Console.WriteLine($"Grad 1: x = {-c / b}");
        }
        return;
    }

    double delta = b * b - 4 * a * c;
    if (delta < 0) {
        Console.WriteLine("Fara radacini reale");
    }
    else if (delta == 0) {
        Console.WriteLine($"Radacina dubla: x = {-b / (2 * a)}");
    }
    else {
        double radacina1 = (-b + Math.Sqrt(delta)) / (2 * a);
        double radacina2 = (-b - Math.Sqrt(delta)) / (2 * a);
        Console.WriteLine($"x1 = {radacina1}");
        Console.WriteLine($"x2 = {radacina2}");
    }
}

static void T3() {
    Console.Write("n = ");
    long n = long.Parse(Console.ReadLine());

    Console.Write("k = ");
    long k = long.Parse(Console.ReadLine());

    if (k == 0) {
        Console.WriteLine("Nu merge cu 0");
    }
    else {
        Console.WriteLine(n % k == 0 ?
            $"{n} se divide cu {k}" :
            $"{n} nu se divide cu {k}");
    }
}

static void T4() {
    Console.Write("An: ");
    int an = int.Parse(Console.ReadLine());

    bool este_bisect = (an % 4 == 0 && an % 100 != 0) || (an % 400 == 0);
    Console.WriteLine(este_bisect ? "An bisect" : "An obisnuit");
}

static void T5() {
    Console.Write("Numar: ");
    long n = long.Parse(Console.ReadLine());

    Console.Write("Pozitia de la dreapta: ");
    int k = int.Parse(Console.ReadLine());

    long temp = Math.Abs(n);
    for (int i = 1; i < k; i++) {
        temp /= 10;
    }

    if (temp == 0) {
        Console.WriteLine("Nu exista cifra");
    }
    else {
        Console.WriteLine($"Cifra {k}: {temp % 10}");
    }
}

static void T6() {
    Console.Write("a = ");
    double a = double.Parse(Console.ReadLine());

    Console.Write("b = ");
    double b = double.Parse(Console.ReadLine());

    Console.Write("c = ");
    double c = double.Parse(Console.ReadLine());

    bool este_triunghi = a > 0 && b > 0 && c > 0 &&
                         (a + b > c) &&
                         (a + c > b) &&
                         (b + c > a);

    Console.WriteLine(este_triunghi ? "E triunghi" : "Nu e triunghi");
}

static void T7() {
    Console.Write("a = ");
    long a = long.Parse(Console.ReadLine());

    Console.Write("b = ");
    long b = long.Parse(Console.ReadLine());

    long temp = a;
    a = b;
    b = temp;

    Console.WriteLine($"a = {a}, b = {b}");
}

static void T8() {
    Console.Write("a = ");
    long a = long.Parse(Console.ReadLine());

    Console.Write("b = ");
    long b = long.Parse(Console.ReadLine());

    a = a + b;
    b = a - b;
    a = a - b;

    Console.WriteLine($"a = {a}, b = {b}");
}

static void T9() {
    Console.Write("n = ");
    int n = int.Parse(Console.ReadLine());

    Console.WriteLine($"Divizorii lui {n}:");
    for (int i = 1; i <= n; i++) {
        if (n % i == 0) {
            Console.Write(i + " ");
        }
    }
    Console.WriteLine();
}

static void T10() {
    Console.Write("n = ");
    int n = int.Parse(Console.ReadLine());

    if (n < 2) {
        Console.WriteLine("Nu e prim");
        return;
    }

    bool este_prim = true;
    int i = 2;
    while (i * i <= n) {
        if (n % i == 0) {
            este_prim = false;
            break;
        }
        i++;
    }

    Console.WriteLine(este_prim ? "Prim" : "Compus");
}

static void T11() {
    Console.Write("Numar: ");
    long n = long.Parse(Console.ReadLine());

    long temp = Math.Abs(n);
    Console.WriteLine("Cifrele invers:");

    if (temp == 0) {
        Console.WriteLine("0");
    }
    else {
        while (temp > 0) {
            Console.Write(temp % 10 + " ");
            temp /= 10;
        }
        Console.WriteLine();
    }
}

static void T12() {
    Console.Write("a = ");
    long a = long.Parse(Console.ReadLine());

    Console.Write("b = ");
    long b = long.Parse(Console.ReadLine());

    Console.Write("n = ");
    long divizor = long.Parse(Console.ReadLine());

    long inceput = a;
    long sfarsit = b;
    if (inceput > sfarsit) {
        long temp = inceput;
        inceput = sfarsit;
        sfarsit = temp;
    }

    long contor = 0;
    for (long n = inceput; n <= sfarsit; n++) {
        if (n % divizor == 0) {
            contor++;
        }
    }

    Console.WriteLine($"Numere divizibile cu {divizor}: {contor}");
}

static void T13() {
    Console.Write("An start: ");
    int inceput = int.Parse(Console.ReadLine());

    Console.Write("An final: ");
    int sfarsit = int.Parse(Console.ReadLine());

    if (inceput > sfarsit) {
        int temp = inceput;
        inceput = sfarsit;
        sfarsit = temp;
    }

    int contor = 0;
    for (int an = inceput; an <= sfarsit; an++) {
        if ((an % 4 == 0 && an % 100 != 0) || (an % 400 == 0)) {
            contor++;
        }
    }

    Console.WriteLine($"Ani bisecti: {contor}");
}

static void T14() {
    Console.Write("Numar: ");
    long n = long.Parse(Console.ReadLine());

    long temp = Math.Abs(n);
    long invers = 0;
    long original = temp;

    while (temp > 0) {
        invers = invers * 10 + (temp % 10);
        temp /= 10;
    }

    Console.WriteLine(invers == original ? "Palindrom" : "Nu e palindrom");
}

static void T15() {
    Console.Write("x = ");
    double x = double.Parse(Console.ReadLine());

    Console.Write("y = ");
    double y = double.Parse(Console.ReadLine());

    Console.Write("z = ");
    double z = double.Parse(Console.ReadLine());

    if (x > y) {
        double temp = x;
        x = y;
        y = temp;
    }
    if (y > z) {
        double temp = y;
        y = z;
        z = temp;
    }
    if (x > y) {
        double temp = x;
        x = y;
        y = temp;
    }

    Console.WriteLine($"Ordine: {x} {y} {z}");
}

static void T16() {
    Console.WriteLine("Scrie 5 numere:");
    Console.Write("a = ");
    double nr1 = double.Parse(Console.ReadLine());

    Console.Write("b = ");
    double nr2 = double.Parse(Console.ReadLine());

    Console.Write("c = ");
    double nr3 = double.Parse(Console.ReadLine());

    Console.Write("d = ");
    double nr4 = double.Parse(Console.ReadLine());

    Console.Write("e = ");
    double nr5 = double.Parse(Console.ReadLine());

    for (int i = 0; i < 4; i++) {
        if (nr1 > nr2) { double t = nr1; nr1 = nr2; nr2 = t; }
        if (nr2 > nr3) { double t = nr2; nr2 = nr3; nr3 = t; }
        if (nr3 > nr4) { double t = nr3; nr3 = nr4; nr4 = t; }
        if (nr4 > nr5) { double t = nr4; nr4 = nr5; nr5 = t; }
    }

    Console.WriteLine($"Ordine: {nr1} {nr2} {nr3} {nr4} {nr5}");
}

static int CalculeazaCMMDC(int a, int b) {
    a = Math.Abs(a);
    b = Math.Abs(b);

    while (b != 0) {
        int rest = a % b;
        a = b;
        b = rest;
    }

    return a;
}

static void T17() {
    Console.Write("a = ");
    int a = int.Parse(Console.ReadLine());

    Console.Write("b = ");
    int b = int.Parse(Console.ReadLine());

    int cmmdc = CalculeazaCMMDC(a, b);
    long cmmmc = (long)Math.Abs(a) / cmmdc * Math.Abs(b);

    Console.WriteLine($"CMMDC = {cmmdc}");
    Console.WriteLine($"CMMMC = {cmmmc}");
}

static void T18() {
    Console.Write("n = ");
    long n = long.Parse(Console.ReadLine());

    Console.WriteLine("Factori primi:");
    long temp = n;
    long factor = 2;
    bool primul_factor = true;

    while (factor * factor <= temp) {
        int putere = 0;
        while (temp % factor == 0) {
            putere++;
            temp /= factor;
        }

        if (putere > 0) {
            if (!primul_factor) {
                Console.Write(" × ");
            }
            Console.Write($"{factor}");
            if (putere > 1) {
                Console.Write($"^{putere}");
            }
            primul_factor = false;
        }
        factor++;
    }

    if (temp > 1) {
        if (!primul_factor) {
            Console.Write(" × ");
        }
        Console.Write($"{temp}");
    }

    Console.WriteLine();
}

static void T19() {
    Console.Write("Numar: ");
    long n = long.Parse(Console.ReadLine());

    n = Math.Abs(n);

    if (n == 0) {
        Console.WriteLine("O cifra: 0");
        return;
    }

    int a = -1;
    int b = -1;
    long temp = n;
    bool max_doua = true;

    while (temp > 0) {
        int cifra = (int)(temp % 10);

        if (a == -1) {
            a = cifra;
        }
        else if (a != cifra && b == -1) {
            b = cifra;
        }
        else if (a != cifra && b != cifra) {
            max_doua = false;
            break;
        }

        temp /= 10;
    }

    Console.WriteLine(max_doua ?
        "Max 2 cifre diferite" :
        "Mai mult de 2 cifre distincte");
}

static void T20() {
    Console.Write("m = ");
    int numarator = int.Parse(Console.ReadLine());

    Console.Write("n = ");
    int numitor = int.Parse(Console.ReadLine());

    int semn = 1;
    int numar_abs = numarator;
    int numitor_abs = numitor;

    if (numar_abs < 0) {
        semn *= -1;
        numar_abs = -numar_abs;
    }
    if (numitor_abs < 0) {
        semn *= -1;
        numitor_abs = -numitor_abs;
    }

    int parte_intreaga = numar_abs / numitor_abs;
    int rest = numar_abs % numitor_abs;

    string rezultat = "";
    if (semn < 0 && (parte_intreaga != 0 || rest != 0)) {
        rezultat += "-";
    }
    rezultat += parte_intreaga.ToString();

    if (rest == 0) {
        Console.WriteLine(rezultat);
        return;
    }

    rezultat += ".";

    int[] cifre_zecimale = new int[10000];
    int[] resturi_vazute = new int[10000];
    int numar_cifre = 0;
    int pozitie_period = -1;

    while (rest != 0 && numar_cifre < 10000) {
        for (int i = 0; i < numar_cifre; i++) {
            if (resturi_vazute[i] == rest) {
                pozitie_period = i;
                break;
            }
        }

        if (pozitie_period != -1) {
            break;
        }

        resturi_vazute[numar_cifre] = rest;
        rest *= 10;
        int catul = rest / numitor_abs;
        cifre_zecimale[numar_cifre] = catul;
        rest = rest % numitor_abs;
        numar_cifre++;
    }

    if (pozitie_period == -1) {
        for (int i = 0; i < numar_cifre; i++) {
            rezultat += cifre_zecimale[i];
        }
    }
    else {
        for (int i = 0; i < pozitie_period; i++) {
            rezultat += cifre_zecimale[i];
        }
        rezultat += "(";
        for (int i = pozitie_period; i < numar_cifre; i++) {
            rezultat += cifre_zecimale[i];
        }
        rezultat += ")";
    }

    Console.WriteLine(rezultat);
}

static void T21() {
    Console.WriteLine("Gandeste-te la un nr intre 1 si 1024");
    int limita_jos = 1;
    int limita_sus = 1024;

    while (limita_jos < limita_sus) {
        int ghicit = limita_jos + (limita_sus - limita_jos) / 2;
        Console.Write($"E >= {ghicit}? (d/n): ");
        string raspuns = Console.ReadLine();
        if (raspuns == null) raspuns = "";
        raspuns = raspuns.Trim().ToLower();

        if (raspuns == "d" || raspuns == "da" || raspuns == "y" || raspuns == "yes") {
            limita_jos = ghicit;
        }
        else {
            limita_sus = ghicit - 1;
        }
    }

    Console.WriteLine($"Numarul e {limita_jos}");
}
