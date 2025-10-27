while (true) {
    Console.Write("Alege optiune (? pt ajutor): ");

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
        case "22": T22(); break;
        case "23": T23(); break;
        case "24": T24(); break;
        case "25": T25(); break;
        case "26": T26(); break;
        case "27": T27(); break;
        case "28": T28(); break;
        case "29": T29(); break;
        case "30": T30(); break;
        case "31": T31(); break;
        case "?":
            Console.WriteLine("Optiuni: 1-31");
            break;
        default:
            return 0;
    }

    Console.WriteLine();
}

static void T1() {
    Console.Write("n = ");
    int n = int.Parse(Console.ReadLine());

    int[] v = new int[n];
    for (int i = 0; i < n; i++) {
        Console.Write($"v[{i}] = ");
        v[i] = int.Parse(Console.ReadLine());
    }

    int suma = 0;
    for (int i = 0; i < n; i++) {
        suma += v[i];
    }

    Console.WriteLine($"Suma: {suma}");
}

static void T2() {
    Console.Write("n = ");
    int n = int.Parse(Console.ReadLine());

    int[] v = new int[n];
    for (int i = 0; i < n; i++) {
        Console.Write($"v[{i}] = ");
        v[i] = int.Parse(Console.ReadLine());
    }

    Console.Write("k = ");
    int k = int.Parse(Console.ReadLine());

    int poz = -1;
    for (int i = 0; i < n; i++) {
        if (v[i] == k) {
            poz = i;
            break;
        }
    }

    Console.WriteLine($"Pozitie: {poz}");
}

static void T3() {
    Console.Write("n = ");
    int n = int.Parse(Console.ReadLine());

    int[] v = new int[n];
    for (int i = 0; i < n; i++) {
        Console.Write($"v[{i}] = ");
        v[i] = int.Parse(Console.ReadLine());
    }

    int min, max, poz_min, poz_max;
    int start;

    if (n % 2 == 1) {
        min = v[0];
        max = v[0];
        poz_min = 0;
        poz_max = 0;
        start = 1;
    }
    else {
        if (v[0] < v[1]) {
            min = v[0];
            max = v[1];
            poz_min = 0;
            poz_max = 1;
        }
        else {
            min = v[1];
            max = v[0];
            poz_min = 1;
            poz_max = 0;
        }
        start = 2;
    }

    for (int i = start; i < n; i += 2) {
        int a = v[i];
        int b = v[i + 1];

        if (a < b) {
            if (a < min) {
                min = a;
                poz_min = i;
            }
            if (b > max) {
                max = b;
                poz_max = i + 1;
            }
        }
        else {
            if (b < min) {
                min = b;
                poz_min = i + 1;
            }
            if (a > max) {
                max = a;
                poz_max = i;
            }
        }
    }

    Console.WriteLine($"Min: {min} la poz {poz_min}");
    Console.WriteLine($"Max: {max} la poz {poz_max}");
}

static void T4() {
    Console.Write("n = ");
    int n = int.Parse(Console.ReadLine());

    int[] v = new int[n];
    for (int i = 0; i < n; i++) {
        Console.Write($"v[{i}] = ");
        v[i] = int.Parse(Console.ReadLine());
    }

    int min = v[0];
    int max = v[0];
    int cnt_min = 1;
    int cnt_max = 1;

    for (int i = 1; i < n; i++) {
        if (v[i] < min) {
            min = v[i];
            cnt_min = 1;
        }
        else if (v[i] == min) {
            cnt_min++;
        }

        if (v[i] > max) {
            max = v[i];
            cnt_max = 1;
        }
        else if (v[i] == max) {
            cnt_max++;
        }
    }

    Console.WriteLine($"Min: {min} apare de {cnt_min} ori");
    Console.WriteLine($"Max: {max} apare de {cnt_max} ori");
}

static void T5() {
    Console.Write("n = ");
    int n = int.Parse(Console.ReadLine());

    int[] v = new int[n];
    for (int i = 0; i < n; i++) {
        Console.Write($"v[{i}] = ");
        v[i] = int.Parse(Console.ReadLine());
    }

    Console.Write("e = ");
    int e = int.Parse(Console.ReadLine());

    Console.Write("k = ");
    int k = int.Parse(Console.ReadLine());

    if (k < 0) k = 0;
    if (k > n) k = n;

    int[] rez = new int[n + 1];
    for (int i = 0; i < k; i++) {
        rez[i] = v[i];
    }
    rez[k] = e;
    for (int i = k; i < n; i++) {
        rez[i + 1] = v[i];
    }

    Console.WriteLine("Dupa inserare:");
    for (int i = 0; i < n + 1; i++) {
        Console.Write(rez[i] + " ");
    }
    Console.WriteLine();
}

static void T6() {
    Console.Write("n = ");
    int n = int.Parse(Console.ReadLine());

    int[] v = new int[n];
    for (int i = 0; i < n; i++) {
        Console.Write($"v[{i}] = ");
        v[i] = int.Parse(Console.ReadLine());
    }

    Console.Write("k = ");
    int k = int.Parse(Console.ReadLine());

    for (int i = k; i < n - 1; i++) {
        v[i] = v[i + 1];
    }

    Console.WriteLine("Dupa stergere:");
    for (int i = 0; i < n - 1; i++) {
        Console.Write(v[i] + " ");
    }
    Console.WriteLine();
}

static void T7() {
    Console.Write("n = ");
    int n = int.Parse(Console.ReadLine());

    int[] v = new int[n];
    for (int i = 0; i < n; i++) {
        Console.Write($"v[{i}] = ");
        v[i] = int.Parse(Console.ReadLine());
    }

    for (int i = 0; i < n / 2; i++) {
        int t = v[i];
        v[i] = v[n - 1 - i];
        v[n - 1 - i] = t;
    }

    Console.WriteLine("Inversat:");
    for (int i = 0; i < n; i++) {
        Console.Write(v[i] + " ");
    }
    Console.WriteLine();
}

static void T8() {
    Console.Write("n = ");
    int n = int.Parse(Console.ReadLine());

    int[] v = new int[n];
    for (int i = 0; i < n; i++) {
        Console.Write($"v[{i}] = ");
        v[i] = int.Parse(Console.ReadLine());
    }

    int prim = v[0];
    for (int i = 0; i < n - 1; i++) {
        v[i] = v[i + 1];
    }
    v[n - 1] = prim;

    Console.WriteLine("Rotire stanga:");
    for (int i = 0; i < n; i++) {
        Console.Write(v[i] + " ");
    }
    Console.WriteLine();
}

static void T9() {
    Console.Write("n = ");
    int n = int.Parse(Console.ReadLine());

    int[] v = new int[n];
    for (int i = 0; i < n; i++) {
        Console.Write($"v[{i}] = ");
        v[i] = int.Parse(Console.ReadLine());
    }

    Console.Write("k = ");
    int k = int.Parse(Console.ReadLine());

    k = ((k % n) + n) % n;

    int[] buf = new int[k];
    for (int i = 0; i < k; i++) {
        buf[i] = v[i];
    }

    for (int i = 0; i < n - k; i++) {
        v[i] = v[i + k];
    }

    for (int i = 0; i < k; i++) {
        v[n - k + i] = buf[i];
    }

    Console.WriteLine($"Rotire stanga cu {k}:");
    for (int i = 0; i < n; i++) {
        Console.Write(v[i] + " ");
    }
    Console.WriteLine();
}

static void T10() {
    Console.Write("n (sortat crescator) = ");
    int n = int.Parse(Console.ReadLine());

    int[] v = new int[n];
    for (int i = 0; i < n; i++) {
        Console.Write($"v[{i}] = ");
        v[i] = int.Parse(Console.ReadLine());
    }

    Console.Write("k = ");
    int k = int.Parse(Console.ReadLine());

    int st = 0;
    int dr = n - 1;
    int poz = -1;

    while (st <= dr) {
        int mij = st + (dr - st) / 2;

        if (v[mij] == k) {
            poz = mij;
            break;
        }
        else if (v[mij] < k) {
            st = mij + 1;
        }
        else {
            dr = mij - 1;
        }
    }

    Console.WriteLine($"Pozitie: {poz}");
}

static void T11() {
    Console.Write("n = ");
    int n = int.Parse(Console.ReadLine());

    bool[] prim = new bool[n + 1];
    for (int i = 2; i <= n; i++) {
        prim[i] = true;
    }

    for (int i = 2; i * i <= n; i++) {
        if (prim[i]) {
            for (int j = i * i; j <= n; j += i) {
                prim[j] = false;
            }
        }
    }

    Console.WriteLine("Prime:");
    for (int i = 2; i <= n; i++) {
        if (prim[i]) {
            Console.Write(i + " ");
        }
    }
    Console.WriteLine();
}

static void T12() {
    Console.Write("n = ");
    int n = int.Parse(Console.ReadLine());

    int[] v = new int[n];
    for (int i = 0; i < n; i++) {
        Console.Write($"v[{i}] = ");
        v[i] = int.Parse(Console.ReadLine());
    }

    for (int i = 0; i < n - 1; i++) {
        int idx_min = i;
        for (int j = i + 1; j < n; j++) {
            if (v[j] < v[idx_min]) {
                idx_min = j;
            }
        }
        int t = v[i];
        v[i] = v[idx_min];
        v[idx_min] = t;
    }

    Console.WriteLine("Sortat (selection):");
    for (int i = 0; i < n; i++) {
        Console.Write(v[i] + " ");
    }
    Console.WriteLine();
}

static void T13() {
    Console.Write("n = ");
    int n = int.Parse(Console.ReadLine());

    int[] v = new int[n];
    for (int i = 0; i < n; i++) {
        Console.Write($"v[{i}] = ");
        v[i] = int.Parse(Console.ReadLine());
    }

    for (int i = 1; i < n; i++) {
        int elem = v[i];
        int j = i - 1;

        while (j >= 0 && v[j] > elem) {
            v[j + 1] = v[j];
            j--;
        }
        v[j + 1] = elem;
    }

    Console.WriteLine("Sortat (insertion):");
    for (int i = 0; i < n; i++) {
        Console.Write(v[i] + " ");
    }
    Console.WriteLine();
}

static void T14() {
    Console.Write("n = ");
    int n = int.Parse(Console.ReadLine());

    int[] v = new int[n];
    for (int i = 0; i < n; i++) {
        Console.Write($"v[{i}] = ");
        v[i] = int.Parse(Console.ReadLine());
    }

    int w = 0;

    for (int i = 0; i < n; i++) {
        if (v[i] != 0) {
            if (i != w) {
                v[w] = v[i];
                v[i] = 0;
            }

            w++;
        }
    }

    Console.WriteLine("Zerouri la sfarsit:");
    for (int i = 0; i < n; i++) {
        Console.Write(v[i] + " ");
    }
    Console.WriteLine();
}

static void T15() {
    Console.Write("n = ");
    int n = int.Parse(Console.ReadLine());

    int[] v = new int[n];
    for (int i = 0; i < n; i++) {
        Console.Write($"v[{i}] = ");
        v[i] = int.Parse(Console.ReadLine());
    }

    int nou = 0;
    for (int i = 0; i < n; i++) {
        bool gasit = false;
        for (int j = 0; j < nou; j++) {
            if (v[j] == v[i]) {
                gasit = true;
                break;
            }
        }

        if (!gasit) {
            v[nou] = v[i];
            nou++;
        }
    }

    Console.WriteLine("Fara duplicate:");
    for (int i = 0; i < nou; i++) {
        Console.Write(v[i] + " ");
    }
    Console.WriteLine();
}

static int CMMDC(int a, int b) {
    while (b != 0) {
        int r = a % b;
        a = b;
        b = r;
    }
    return a;
}

static void T16() {
    Console.Write("n = ");
    int n = int.Parse(Console.ReadLine());

    int[] v = new int[n];
    for (int i = 0; i < n; i++) {
        Console.Write($"v[{i}] = ");
        v[i] = int.Parse(Console.ReadLine());
    }

    int rez = v[0];
    for (int i = 1; i < n; i++) {
        rez = CMMDC(rez, v[i]);
    }

    Console.WriteLine($"CMMDC: {rez}");
}

static void T17() {
    Console.Write("Numar in baza 10: ");
    int num = int.Parse(Console.ReadLine());

    Console.Write("Baza (2-16): ");
    int b = int.Parse(Console.ReadLine());

    if (num == 0) {
        Console.WriteLine("0");
        return;
    }

    string cifre = "0123456789ABCDEF";
    string rez = "";

    while (num > 0) {
        int r = num % b;
        rez = cifre[r] + rez;
        num /= b;
    }

    Console.WriteLine($"In baza {b}: {rez}");
}

static void T18() {
    Console.Write("Grad polinom n: ");
    int n = int.Parse(Console.ReadLine());

    double[] a = new double[n + 1];
    for (int i = 0; i <= n; i++) {
        Console.Write($"a[{i}] = ");
        a[i] = double.Parse(Console.ReadLine());
    }

    Console.Write("x = ");
    double x = double.Parse(Console.ReadLine());

    double val = a[n];
    for (int i = n - 1; i >= 0; i--) {
        val = val * x + a[i];
    }

    Console.WriteLine($"P({x}) = {val}");
}

static void T19() {
    Console.Write("Dim s: ");
    int ns = int.Parse(Console.ReadLine());

    int[] s = new int[ns];
    for (int i = 0; i < ns; i++) {
        Console.Write($"s[{i}] = ");
        s[i] = int.Parse(Console.ReadLine());
    }

    Console.Write("Dim p: ");
    int np = int.Parse(Console.ReadLine());

    int[] p = new int[np];
    for (int i = 0; i < np; i++) {
        Console.Write($"p[{i}] = ");
        p[i] = int.Parse(Console.ReadLine());
    }

    int cnt = 0;
    for (int i = 0; i <= ns - np; i++) {
        bool ok = true;
        for (int j = 0; j < np; j++) {
            if (s[i + j] != p[j]) {
                ok = false;
                break;
            }
        }
        if (ok) {
            cnt++;
        }
    }

    Console.WriteLine($"Aparitii: {cnt}");
}

static void T20() {
    Console.Write("Margele s1: ");
    int n1 = int.Parse(Console.ReadLine());

    int[] s1 = new int[n1];
    for (int i = 0; i < n1; i++) {
        Console.Write($"s1[{i}] (0/1) = ");
        s1[i] = int.Parse(Console.ReadLine());
    }

    Console.Write("Margele s2: ");
    int n2 = int.Parse(Console.ReadLine());

    int[] s2 = new int[n2];
    for (int i = 0; i < n2; i++) {
        Console.Write($"s2[{i}] (0/1) = ");
        s2[i] = int.Parse(Console.ReadLine());
    }

    int cnt = 0;

    for (int rot = 0; rot < n2; rot++) {
        int[] s2r = new int[n2];
        for (int i = 0; i < n2; i++) {
            s2r[i] = s2[(i + rot) % n2];
        }

        for (int d = -n2 + 1; d <= n1 - 1; d++) {
            bool ok = true;
            for (int i = 0; i < n2; i++) {
                int p = d + i;
                if (p < 0 || p >= n1) {
                    continue;
                }
                if (s1[p] != s2r[i]) {
                    ok = false;
                    break;
                }
            }
            if (ok) {
                cnt++;
            }
        }
    }

    Console.WriteLine($"Suprapuneri: {cnt}");
}

static void T21() {
    Console.Write("Dim v1: ");
    int n1 = int.Parse(Console.ReadLine());

    int[] v1 = new int[n1];
    for (int i = 0; i < n1; i++) {
        Console.Write($"v1[{i}] = ");
        v1[i] = int.Parse(Console.ReadLine());
    }

    Console.Write("Dim v2: ");
    int n2 = int.Parse(Console.ReadLine());

    int[] v2 = new int[n2];
    for (int i = 0; i < n2; i++) {
        Console.Write($"v2[{i}] = ");
        v2[i] = int.Parse(Console.ReadLine());
    }

    int i1 = 0;
    int i2 = 0;

    while (i1 < n1 && i2 < n2) {
        if (v1[i1] < v2[i2]) {
            Console.WriteLine("v1 < v2");
            return;
        }
        else if (v1[i1] > v2[i2]) {
            Console.WriteLine("v2 < v1");
            return;
        }
        else {
            i1++;
            i2++;
        }
    }

    if (n1 < n2) {
        Console.WriteLine("v1 < v2");
    }
    else if (n1 > n2) {
        Console.WriteLine("v2 < v1");
    }
    else {
        Console.WriteLine("Egali");
    }
}

static bool Exista(int[] v, int len, int val) {
    for (int i = 0; i < len; i++) {
        if (v[i] == val) {
            return true;
        }
    }
    return false;
}

static void T22() {
    Console.Write("Dim v1: ");
    int n1 = int.Parse(Console.ReadLine());

    int[] v1 = new int[n1];
    for (int i = 0; i < n1; i++) {
        Console.Write($"v1[{i}] = ");
        v1[i] = int.Parse(Console.ReadLine());
    }

    Console.Write("Dim v2: ");
    int n2 = int.Parse(Console.ReadLine());

    int[] v2 = new int[n2];
    for (int i = 0; i < n2; i++) {
        Console.Write($"v2[{i}] = ");
        v2[i] = int.Parse(Console.ReadLine());
    }

    int[] vect = new int[Math.Min(n1, n2)];
    int li = 0;

    for (int i = 0; i < n1; i++) {
        for (int j = 0; j < n2; j++) {
            if (v1[i] == v2[j]) {
                if (!Exista(vect, li, v1[i])) {
                    vect[li] = v1[i];
                    li++;
                }
                break;
            }
        }
    }

    int[] reun = new int[n1 + n2];
    int lr = 0;

    for (int i = 0; i < n1; i++) {
        if (!Exista(reun, lr, v1[i])) {
            reun[lr] = v1[i];
            lr++;
        }
    }

    for (int i = 0; i < n2; i++) {
        if (!Exista(reun, lr, v2[i])) {
            reun[lr] = v2[i];
            lr++;
        }
    }

    int[] dif1 = new int[n1];
    int ld1 = 0;

    for (int i = 0; i < n1; i++) {
        if (!Exista(v2, n2, v1[i]) && !Exista(dif1, ld1, v1[i])) {
            dif1[ld1] = v1[i];
            ld1++;
        }
    }

    int[] dif2 = new int[n2];
    int ld2 = 0;

    for (int i = 0; i < n2; i++) {
        if (!Exista(v1, n1, v2[i]) && !Exista(dif2, ld2, v2[i])) {
            dif2[ld2] = v2[i];
            ld2++;
        }
    }

    Console.Write("Intersectie: ");
    for (int i = 0; i < li; i++) {
        Console.Write(inters[i] + " ");
    }
    Console.WriteLine();

    Console.Write("Reuniune: ");
    for (int i = 0; i < lr; i++) {
        Console.Write(reun[i] + " ");
    }
    Console.WriteLine();

    Console.Write("Dif v1-v2: ");
    for (int i = 0; i < ld1; i++) {
        Console.Write(dif1[i] + " ");
    }
    Console.WriteLine();

    Console.Write("Dif v2-v1: ");
    for (int i = 0; i < ld2; i++) {
        Console.Write(dif2[i] + " ");
    }
    Console.WriteLine();
}

static void T23() {
    Console.Write("Dim univers m: ");
    int m = int.Parse(Console.ReadLine());

    int[] v1 = new int[m];
    int[] v2 = new int[m];

    Console.WriteLine("Vector v1 (0/1):");
    for (int i = 0; i < m; i++) {
        Console.Write($"v1[{i}] = ");
        v1[i] = int.Parse(Console.ReadLine());
    }

    Console.WriteLine("Vector v2:");
    for (int i = 0; i < m; i++) {
        Console.Write($"v2[{i}] = ");
        v2[i] = int.Parse(Console.ReadLine());
    }

    int[] inters = new int[m];
    int[] reun = new int[m];
    int[] dif1 = new int[m];
    int[] dif2 = new int[m];

    for (int i = 0; i < m; i++) {
        inters[i] = (v1[i] == 1 && v2[i] == 1) ? 1 : 0;
        reun[i] = (v1[i] == 1 || v2[i] == 1) ? 1 : 0;
        dif1[i] = (v1[i] == 1 && v2[i] == 0) ? 1 : 0;
        dif2[i] = (v2[i] == 1 && v1[i] == 0) ? 1 : 0;
    }

    Console.Write("Intersectie: ");
    for (int i = 0; i < m; i++) {
        Console.Write(inters[i] + " ");
    }
    Console.WriteLine();

    Console.Write("Reuniune: ");
    for (int i = 0; i < m; i++) {
        Console.Write(reun[i] + " ");
    }
    Console.WriteLine();

    Console.Write("Dif v1-v2: ");
    for (int i = 0; i < m; i++) {
        Console.Write(dif1[i] + " ");
    }
    Console.WriteLine();

    Console.Write("Dif v2-v1: ");
    for (int i = 0; i < m; i++) {
        Console.Write(dif2[i] + " ");
    }
    Console.WriteLine();
}

static void T24() {
    Console.Write("Dim v1: ");
    int n1 = int.Parse(Console.ReadLine());

    int[] v1 = new int[n1];
    for (int i = 0; i < n1; i++) {
        Console.Write($"v1[{i}] = ");
        v1[i] = int.Parse(Console.ReadLine());
    }

    Console.Write("Dim v2: ");
    int n2 = int.Parse(Console.ReadLine());

    int[] v2 = new int[n2];
    for (int i = 0; i < n2; i++) {
        Console.Write($"v2[{i}] = ");
        v2[i] = int.Parse(Console.ReadLine());
    }

    int[] rez = new int[n1 + n2];
    for (int i = 0; i < n1; i++) {
        rez[i] = v1[i];
    }
    for (int i = 0; i < n2; i++) {
        rez[n1 + i] = v2[i];
    }

    Console.WriteLine("Concatenare:");
    for (int i = 0; i < n1 + n2; i++) {
        Console.Write(rez[i] + " ");
    }
    Console.WriteLine();
}

static void T25() {
    Console.Write("Dim v1: ");
    int n1 = int.Parse(Console.ReadLine());

    int[] v1 = new int[n1];
    for (int i = 0; i < n1; i++) {
        Console.Write($"v1[{i}] = ");
        v1[i] = int.Parse(Console.ReadLine());
    }

    Console.Write("Dim v2: ");
    int n2 = int.Parse(Console.ReadLine());

    int[] v2 = new int[n2];
    for (int i = 0; i < n2; i++) {
        Console.Write($"v2[{i}] = ");
        v2[i] = int.Parse(Console.ReadLine());
    }

    int[] rez = new int[n1 + n2];
    int i1 = 0;
    int i2 = 0;
    int ir = 0;

    while (i1 < n1 && i2 < n2) {
        if (v1[i1] <= v2[i2]) {
            rez[ir] = v1[i1];
            ir++;
            i1++;
        }
        else {
            rez[ir] = v2[i2];
            ir++;
            i2++;
        }
    }

    while (i1 < n1) {
        rez[ir] = v1[i1];
        ir++;
        i1++;
    }

    while (i2 < n2) {
        rez[ir] = v2[i2];
        ir++;
        i2++;
    }

    Console.WriteLine("Interclasat:");
    for (int i = 0; i < ir; i++) {
        Console.Write(rez[i] + " ");
    }
    Console.WriteLine();
}

static int[] EliminaZero(int[] arr, int len, out int nou) {
    int start = 0;
    while (start < len - 1 && arr[start] == 0) {
        start++;
    }
    nou = len - start;
    int[] rez = new int[nou];
    for (int j = 0; j < nou; j++) {
        rez[j] = arr[start + j];
    }
    return rez;
}

static void Adunare(int[] a, int la, int[] b, int lb, out int[] rez, out int lr) {
    int ia = la - 1;
    int ib = lb - 1;
    int t = 0;
    int[] buf = new int[Math.Max(la, lb) + 1];
    int idx = buf.Length - 1;

    while (ia >= 0 || ib >= 0 || t != 0) {
        int ca = (ia >= 0) ? a[ia] : 0;
        int cb = (ib >= 0) ? b[ib] : 0;
        int s = ca + cb + t;
        buf[idx] = s % 10;
        t = s / 10;
        idx--;
        ia--;
        ib--;
    }

    int ps = idx + 1;
    lr = buf.Length - ps;
    rez = new int[lr];
    for (int i = 0; i < lr; i++) {
        rez[i] = buf[ps + i];
    }
}

static void Scadere(int[] a, int la, int[] b, int lb, out int[] rez, out int lr) {
    int[] buf = new int[la];
    int ia = la - 1;
    int ib = lb - 1;
    int idx = la - 1;
    int imp = 0;

    while (idx >= 0) {
        int ca = (ia >= 0) ? a[ia] : 0;
        int cb = (ib >= 0) ? b[ib] : 0;
        int d = ca - cb - imp;

        if (d < 0) {
            d += 10;
            imp = 1;
        }
        else {
            imp = 0;
        }

        buf[idx] = d;
        ia--;
        ib--;
        idx--;
    }

    rez = EliminaZero(buf, buf.Length, out lr);
}

static void Inmultire(int[] a, int la, int[] b, int lb, out int[] rez, out int lr) {
    int[] buf = new int[la + lb];

    for (int i = la - 1; i >= 0; i--) {
        int t = 0;
        for (int j = lb - 1; j >= 0; j--) {
            int p = a[i] * b[j] + buf[i + j + 1] + t;
            buf[i + j + 1] = p % 10;
            t = p / 10;
        }
        buf[i] += t;
    }

    rez = EliminaZero(buf, buf.Length, out lr);
}

static void T26() {
    Console.Write("Nr mare 1: ");
    string s1 = Console.ReadLine();

    Console.Write("Nr mare 2: ");
    string s2 = Console.ReadLine();

    int l1 = s1.Length;
    int l2 = s2.Length;
    int[] a = new int[l1];
    int[] b = new int[l2];

    for (int i = 0; i < l1; i++) {
        a[i] = s1[i] - '0';
    }
    for (int i = 0; i < l2; i++) {
        b[i] = s2[i] - '0';
    }

    Adunare(a, l1, b, l2, out int[] suma, out int ls);
    Console.Write("Suma: ");
    for (int i = 0; i < ls; i++) {
        Console.Write(suma[i]);
    }
    Console.WriteLine();

    bool a_mai_mare = false;
    if (l1 > l2) {
        a_mai_mare = true;
    }
    else if (l1 < l2) {
        a_mai_mare = false;
    }
    else {
        int cmp = 0;
        for (int i = 0; i < l1; i++) {
            if (a[i] < b[i]) {
                cmp = -1;
                break;
            }
            else if (a[i] > b[i]) {
                cmp = 1;
                break;
            }
        }
        a_mai_mare = cmp >= 0;
    }

    if (a_mai_mare) {
        Scadere(a, l1, b, l2, out int[] dif, out int ld);
        Console.Write("Dif (a-b): ");
        for (int i = 0; i < ld; i++) {
            Console.Write(dif[i]);
        }
        Console.WriteLine();
    }
    else {
        Scadere(b, l2, a, l1, out int[] dif, out int ld);
        Console.Write("Dif: ");
        for (int i = 0; i < ld; i++) {
            Console.Write(dif[i]);
        }
        Console.WriteLine();
    }

    Inmultire(a, l1, b, l2, out int[] prod, out int lp);
    Console.Write("Produs: ");
    for (int i = 0; i < lp; i++) {
        Console.Write(prod[i]);
    }
    Console.WriteLine();
}

static void T27() {
    Console.Write("n = ");
    int n = int.Parse(Console.ReadLine());

    int[] v = new int[n];
    for (int i = 0; i < n; i++) {
        Console.Write($"v[{i}] = ");
        v[i] = int.Parse(Console.ReadLine());
    }

    Console.Write("Index: ");
    int k = int.Parse(Console.ReadLine());

    int[] cop = new int[n];
    for (int i = 0; i < n; i++) {
        cop[i] = v[i];
    }

    for (int i = 0; i < n - 1; i++) {
        int idx_min = i;
        for (int j = i + 1; j < n; j++) {
            if (cop[j] < cop[idx_min]) {
                idx_min = j;
            }
        }
        int t = cop[i];
        cop[i] = cop[idx_min];
        cop[idx_min] = t;
    }

    Console.WriteLine($"Pe poz {k} dupa sortare: {cop[k]}");
}

static void QuickSort(int[] v, int st, int dr) {
    if (st >= dr) {
        return;
    }

    int piv = v[(st + dr) / 2];
    int i = st;
    int j = dr;

    while (i <= j) {
        while (v[i] < piv) {
            i++;
        }
        while (v[j] > piv) {
            j--;
        }

        if (i <= j) {
            int t = v[i];
            v[i] = v[j];
            v[j] = t;
            i++;
            j--;
        }
    }

    if (st < j) {
        QuickSort(v, st, j);
    }
    if (i < dr) {
        QuickSort(v, i, dr);
    }
}

static void T28() {
    Console.Write("n = ");
    int n = int.Parse(Console.ReadLine());

    int[] v = new int[n];
    for (int i = 0; i < n; i++) {
        Console.Write($"v[{i}] = ");
        v[i] = int.Parse(Console.ReadLine());
    }

    if (n > 0) {
        QuickSort(v, 0, n - 1);
    }

    Console.WriteLine("QuickSort:");
    for (int i = 0; i < n; i++) {
        Console.Write(v[i] + " ");
    }
    Console.WriteLine();
}

static int[] MergeSort(int[] v) {
    int n = v.Length;
    if (n <= 1) {
        return v;
    }

    int mij = n / 2;
    int[] st = new int[mij];
    int[] dr = new int[n - mij];

    for (int i = 0; i < mij; i++) {
        st[i] = v[i];
    }
    for (int i = mij; i < n; i++) {
        dr[i - mij] = v[i];
    }

    st = MergeSort(st);
    dr = MergeSort(dr);

    int[] rez = new int[n];
    int ist = 0;
    int idr = 0;
    int ir = 0;

    while (ist < st.Length && idr < dr.Length) {
        if (st[ist] <= dr[idr]) {
            rez[ir] = st[ist];
            ist++;
        }
        else {
            rez[ir] = dr[idr];
            idr++;
        }
        ir++;
    }

    while (ist < st.Length) {
        rez[ir] = st[ist];
        ist++;
        ir++;
    }

    while (idr < dr.Length) {
        rez[ir] = dr[idr];
        idr++;
        ir++;
    }

    return rez;
}

static void T29() {
    Console.Write("n = ");
    int n = int.Parse(Console.ReadLine());

    int[] v = new int[n];
    for (int i = 0; i < n; i++) {
        Console.Write($"v[{i}] = ");
        v[i] = int.Parse(Console.ReadLine());
    }

    int[] sortat = MergeSort(v);

    Console.WriteLine("MergeSort:");
    for (int i = 0; i < sortat.Length; i++) {
        Console.Write(sortat[i] + " ");
    }
    Console.WriteLine();
}

static void T30() {
    Console.Write("n = ");
    int n = int.Parse(Console.ReadLine());

    int[] e = new int[n];
    int[] w = new int[n];

    for (int i = 0; i < n; i++) {
        Console.Write($"E[{i}] = ");
        e[i] = int.Parse(Console.ReadLine());

        Console.Write($"W[{i}] = ");
        w[i] = int.Parse(Console.ReadLine());
    }

    for (int i = 0; i < n - 1; i++) {
        int best = i;
        for (int j = i + 1; j < n; j++) {
            if (e[j] < e[best]) {
                best = j;
            }
            else if (e[j] == e[best] && w[j] > w[best]) {
                best = j;
            }
        }

        int te = e[i];
        e[i] = e[best];
        e[best] = te;

        int tw = w[i];
        w[i] = w[best];
        w[best] = tw;
    }

    Console.WriteLine("Ordonat:");
    for (int i = 0; i < n; i++) {
        Console.Write(e[i] + "(" + w[i] + ") ");
    }
    Console.WriteLine();
}

static void T31() {
    Console.Write("n = ");
    int n = int.Parse(Console.ReadLine());

    int[] v = new int[n];
    for (int i = 0; i < n; i++) {
        Console.Write($"v[{i}] = ");
        v[i] = int.Parse(Console.ReadLine());
    }

    int cand = v[0];
    int cnt = 1;

    for (int i = 1; i < n; i++) {
        if (v[i] == cand) {
            cnt++;
        }
        else {
            cnt--;
            if (cnt == 0) {
                cand = v[i];
                cnt = 1;
            }
        }
    }

    int ap = 0;
    for (int i = 0; i < n; i++) {
        if (v[i] == cand) {
            ap++;
        }
    }

    if (ap > n / 2) {
        Console.WriteLine($"Majoritar: {cand}");
    }
    else {
        Console.WriteLine("nu exista");
    }
}
