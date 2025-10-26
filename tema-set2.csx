while (true) {
    Console.Write("Alegeți o opțiune (? pt ajutor): ");

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
        case "?":
            Console.WriteLine("Opțiuni: 1-17");
            break;
        default:
            return 0;
    }

    Console.WriteLine();
}

static void T1() {
    Console.Write("n = ");
    int n = int.Parse(Console.ReadLine());
    int pare = 0;

    for (int i = 0; i < n; i++) {
        Console.Write($"Nr {i + 1}: ");
        int x = int.Parse(Console.ReadLine());
        if (x % 2 == 0) pare++;
    }

    Console.WriteLine($"Pare: {pare}");
}

static void T2() {
    Console.Write("n = ");
    int n = int.Parse(Console.ReadLine());
    int neg = 0, zero = 0, poz = 0;

    for (int i = 0; i < n; i++) {
        Console.Write($"Nr {i + 1}: ");
        int x = int.Parse(Console.ReadLine());
        if (x < 0) neg++;
        else if (x == 0) zero++;
        else poz++;
    }

    Console.WriteLine($"Negative: {neg}, Zero: {zero}, Pozitive: {poz}");
}

static void T3() {
    Console.Write("n = ");
    int n = int.Parse(Console.ReadLine());
    long suma = 0, produs = 1;

    for (int i = 1; i <= n; i++) {
        suma += i;
        produs *= i;
    }

    Console.WriteLine($"Suma: {suma}, Produs: {produs}");
}

static void T4() {
    Console.Write("n = ");
    int n = int.Parse(Console.ReadLine());
    Console.Write("a = ");
    int a = int.Parse(Console.ReadLine());
    int poz = -1;

    for (int i = 0; i < n; i++) {
        Console.Write($"Nr {i + 1}: ");
        int x = int.Parse(Console.ReadLine());
        if (x == a && poz == -1) poz = i;
    }

    Console.WriteLine($"Poziție: {poz}");
}

static void T5() {
    Console.Write("n = ");
    int n = int.Parse(Console.ReadLine());
    int contor = 0;

    for (int i = 0; i < n; i++) {
        Console.Write($"Nr {i}: ");
        int x = int.Parse(Console.ReadLine());
        if (x == i) contor++;
    }

    Console.WriteLine($"Elemente val=index: {contor}");
}

static void T6() {
    Console.Write("n = ");
    int n = int.Parse(Console.ReadLine());

    Console.Write("Nr 1: ");
    int prev = int.Parse(Console.ReadLine());
    bool cresc = true;

    for (int i = 1; i < n; i++) {
        Console.Write($"Nr {i + 1}: ");
        int x = int.Parse(Console.ReadLine());
        if (x < prev) cresc = false;
        prev = x;
    }

    Console.WriteLine(cresc ? "DA" : "NU");
}

static void T7() {
    Console.Write("n = ");
    int n = int.Parse(Console.ReadLine());

    Console.Write("Nr 1: ");
    int x = int.Parse(Console.ReadLine());
    int min = x, max = x;

    for (int i = 1; i < n; i++) {
        Console.Write($"Nr {i + 1}: ");
        x = int.Parse(Console.ReadLine());
        if (x < min) min = x;
        if (x > max) max = x;
    }

    Console.WriteLine($"Min: {min}, Max: {max}");
}

static void T8() {
    Console.Write("n = ");
    int n = int.Parse(Console.ReadLine());

    long a = 1, b = 1;
    if (n == 0) { Console.WriteLine($"Fib({n}) = {a}"); return; }
    if (n == 1) { Console.WriteLine($"Fib({n}) = {b}"); return; }

    for (int i = 2; i <= n; i++) {
        long c = a + b;
        a = b; b = c;
    }

    Console.WriteLine($"Fib({n}) = {b}");
}

static void T9() {
    Console.Write("n = ");
    int n = int.Parse(Console.ReadLine());

    Console.Write("Nr 1: ");
    int prev = int.Parse(Console.ReadLine());
    bool cresc = true, desc = true;

    for (int i = 1; i < n; i++) {
        Console.Write($"Nr {i + 1}: ");
        int x = int.Parse(Console.ReadLine());
        if (x < prev) cresc = false;
        if (x > prev) desc = false;
        prev = x;
    }

    Console.WriteLine((cresc || desc) ? "DA" : "NU");
}

static void T10() {
    Console.Write("n = ");
    int n = int.Parse(Console.ReadLine());

    Console.Write("Nr 1: ");
    int prev = int.Parse(Console.ReadLine());
    int lung_max = 1, lung_curent = 1;

    for (int i = 1; i < n; i++) {
        Console.Write($"Nr {i + 1}: ");
        int x = int.Parse(Console.ReadLine());
        lung_curent = (x == prev) ? lung_curent + 1 : 1;
        if (lung_curent > lung_max) lung_max = lung_curent;
        prev = x;
    }

    Console.WriteLine($"Lungime max subsecv identice: {lung_max}");
}

static void T11() {
    Console.Write("n = ");
    int n = int.Parse(Console.ReadLine());
    double suma = 0;

    for (int i = 0; i < n; i++) {
        Console.Write($"Nr {i + 1}: ");
        double x = double.Parse(Console.ReadLine());
        if (x != 0) suma += 1.0 / x;
    }

    Console.WriteLine($"Suma inverselor: {suma}");
}

static void T12() {
    Console.Write("n = ");
    int n = int.Parse(Console.ReadLine());
    int prev = 0, contor = 0;

    for (int i = 0; i < n; i++) {
        Console.Write($"Nr {i + 1}: ");
        int x = int.Parse(Console.ReadLine());
        if (x != 0 && prev == 0) contor++;
        prev = x;
    }

    Console.WriteLine($"Secv non-zero: {contor}");
}

static void T13() {
    Console.Write("n = ");
    int n = int.Parse(Console.ReadLine());

    if (n <= 1) { Console.WriteLine("DA"); return; }

    Console.Write("El 1: ");
    int primul = int.Parse(Console.ReadLine());
    int anterior = primul;
    int rotiri = 0;

    for (int i = 2; i <= n; i++) {
        Console.Write($"El {i}: ");
        int x = int.Parse(Console.ReadLine());

        if (x < anterior) {
            rotiri++;
        }
        anterior = x;
    }

    if (primul < anterior) {
        rotiri++;
    }

    Console.WriteLine(rotiri <= 1 ? "DA" : "NU");
}

static void T14() {
    Console.Write("n = ");
    int n = int.Parse(Console.ReadLine());

    if (n <= 1) { Console.WriteLine("DA"); return; }

    Console.Write("El 1: ");
    int primul = int.Parse(Console.ReadLine());
    int anterior = primul;
    int rotiri_cresc = 0;
    int rotiri_desc = 0;

    for (int i = 2; i <= n; i++) {
        Console.Write($"El {i}: ");
        int x = int.Parse(Console.ReadLine());

        if (x < anterior) rotiri_cresc++;
        if (x > anterior) rotiri_desc++;

        anterior = x;
    }

    if (primul < anterior) rotiri_cresc++;
    if (primul > anterior) rotiri_desc++;

    Console.WriteLine((rotiri_cresc <= 1 || rotiri_desc <= 1) ? "DA" : "NU");
}

static void T15() {
    Console.Write("n = ");
    int n = int.Parse(Console.ReadLine());

    Console.Write("Nr 1: ");
    int anterior = int.Parse(Console.ReadLine());
    bool cresc = true, desc = false, bitonic = true;

    for (int i = 1; i < n; i++) {
        Console.Write($"Nr {i + 1}: ");
        int x = int.Parse(Console.ReadLine());
        if (cresc && x < anterior) { cresc = false; desc = true; }
        else if (desc && x > anterior) bitonic = false;
        anterior = x;
    }

    Console.WriteLine(bitonic ? "DA" : "NU");
}

static void T16() {
    Console.Write("n = ");
    int n = int.Parse(Console.ReadLine());

    if (n == 0) { Console.WriteLine("DA"); return; }

    Console.Write("Nr 1: ");
    int anterior = int.Parse(Console.ReadLine());
    bool cresc = true, desc = false, bitonic = true;

    for (int i = 1; i < n; i++) {
        Console.Write($"Nr {i + 1}: ");
        int x = int.Parse(Console.ReadLine());

        if (x == anterior) continue;

        if (cresc && x < anterior) {
            cresc = false;
            desc = true;
        }
        else if (desc && x > anterior) {
            bitonic = false;
        }

        anterior = x;
    }

    Console.WriteLine(bitonic ? "DA" : "NU");
}

static void T17() {
    Console.Write("n = ");
    int n = int.Parse(Console.ReadLine());

    int nivel = 0, max_nivel = 0;
    bool corect = true;

    for (int i = 0; i < n; i++) {
        Console.Write($"Paranteza {i + 1} (0=deschide, 1=inchide): ");
        int p = int.Parse(Console.ReadLine());
        if (p == 0) nivel++;
        else nivel--;
        if (nivel < 0) corect = false;
        if (nivel > max_nivel) max_nivel = nivel;
    }

    if (nivel != 0) corect = false;
    Console.WriteLine(corect ? $"DA {max_nivel}" : "NU");
}
