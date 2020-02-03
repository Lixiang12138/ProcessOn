#include<bits/stdc++.h>
using namespace std;
//  Thanks for Nakochi's blog and code. See: https://codeforces.com/blog/entry/8576
 
#define BASE 100000000
#define LEN 20
#define LL long long
int N;
int K, L;
struct BIG   //BigInterger
{
public:
    LL a[LEN];
    int len;
} mm[101], low, high, mid, final, tmp, power, ten, bb;
class BB   //BigInterger
{
public:
    LL a[330];
    int len;
} fac_n[1001];
void mul(BIG a, BIG b, BIG &c)   //a*b==>c
{
    int i, j;
    for (i = 0; i < a.len; i++)
        for (j = 0; j < b.len; j++)
        {
            if (i + j - 10 >= 0)
                c.a[i + j - 10] += a.a[i] * b.a[j];
        }
    for (i = 10; i < a.len + b.len + 5; i++)
        c.a[i + 1 - 10] += c.a[i - 10] / BASE, c.a[i - 10] %= BASE;
    for (i = a.len + b.len + 4; i >= 0 && c.a[i - 10] == 0; i--);
    c.len = i + 1 - 10;
}
void div(BIG &a, int n)   //a/n ==> a
{
    int i;
    LL tt = 0;
    for (i = a.len - 1; i >= 0; i--)
    {
        tt = tt * BASE + a.a[i];
        a.a[i] = tt / (LL)n;
        tt %= n;
    }
    if (!a.a[a.len - 1])
        a.len--;
}
void add(BIG a, BIG b, BIG &c)   // a+b ==> c
{
    int i;
    int ll = a.len > b.len ? a.len : b.len;
    for (i = 0; i < ll; i++)
        c.a[i] = a.a[i] + b.a[i];
    for (i = 0; i < ll; i++)
        c.a[i + 1] += c.a[i] / BASE, c.a[i] %= BASE;
    if (c.a[ll])
        c.len = ll + 1;
    else
        c.len = ll;
}
int cmp(BIG &a, BIG &b)   //check if a>b
{
    int i;
    for (i = a.len - 1; i >= 0 && a.a[i] == 0; i--);
    a.len = i + 1;
    for (i = b.len - 1; i >= 0 && b.a[i] == 0; i--);
    b.len = i + 1;
    if (a.len > b.len)
        return 1;
    else if (a.len < b.len)
        return -1;
    for (i = a.len - 1; i >= 7; i--)
    {
        if (a.a[i] != b.a[i])
        {
            if (a.a[i] > b.a[i])
                return 1;
            else
                return -1;
        }
    }
    return 0;
}
void add1(BIG &a)
{
    a.a[10]++;
    if (a.a[10] >= BASE)
    {
        for (int i = 10; i < a.len; i++)
        {
            if (a.a[i] >= BASE)
                a.a[i + 1]++, a.a[i] -= BASE;
        }
    }
    if (a.a[a.len])
        a.len++;
}
void minus1(BIG &a)
{
    a.a[10]--;
    if (a.a[10] < 0)
    {
        for (int i = 10; i < a.len; i++)
        {
            if (a.a[i] < 0)
                a.a[i + 1]--, a.a[i] += BASE;
        }
    }
    if (a.a[a.len - 1] == 0)
        a.len--;
}
void minus2(BIG a, BIG b, BIG &c)   //a-b == c;
{
    int i;
    for (i = 0; i < b.len; i++)
        c.a[i] = a.a[i] - b.a[i];
    for (i = 0; i < a.len; i++)
    {
        if (c.a[i] < 0)
            c.a[i + 1]--, c.a[i] += BASE;
    }
    if (c.a[c.len - 1] == 0)
        c.len--;
}
void print(BIG &a)
{
    int i;
    printf("len = %d\n", a.len);
    for (i = LEN - 1; i >= a.len; i--)
        printf("00000000 ");
    for (i = a.len - 1; i >= 0; i--)
        printf("%I64d ", a.a[i]);
    printf("\n");
}
void get_big_div()   //a/b ==> c,a,b,c are BigIntegers
{
    int tt;
    memset(low.a, 0, sizeof(low.a));
    memset(high.a, 0, sizeof(high.a));
    memset(power.a, 0, sizeof(power.a));
    low.len = 1;
    high = mid;
    while (cmp(low, high) < 0)
    {
        add(low, high, power);
        div(power, 2);
        memset(bb.a, 0, sizeof(bb.a));
        mul(power, ten, bb);
        tt = cmp(bb, mid);
        if (tt == 0)
            break;
        else if (tt < 0)
            low = power;
        else
            high = power;
    }
    mid = power;
}
void f1()
{
    int tt;
    int i;
    memset(final.a, 0, sizeof(final.a));
    memset(low.a, 0, sizeof(low.a));
    memset(high.a, 0, sizeof(high.a));
    memset(mid.a, 0, sizeof(mid.a));
    memset(power.a, 0, sizeof(power.a));
    memset(ten.a, 0, sizeof(ten.a));
    final.a[10] = (LL)N;
    final.len = 11;
    low.a[10] = 1;
    low.len = 11;
    high.a[10] = 20;
    high.len = 11;
    //  mid = ln(N)
    while (cmp(low, high) < 0)
    {
        add(low, high, mid);
        div(mid, 2);
        memset(mm[0].a, 0, sizeof(mm[0].a));
        mm[0].a[10] = 1;
        mm[0].len = 11;
        tmp = mm[0];
        for (i = 1; i <= 78; i++)
        {
            memset(mm[i].a, 0, sizeof(mm[i].a));
            mul(mm[i - 1], mid, mm[i]);
            div(mm[i], i);
            add(mm[i], tmp, tmp);
        }
        tt = cmp(tmp, final);
        if (tt == 0)
            break;
        else if (tt < 0)
            low = mid;
        else
            high = mid;
    }
    memset(tmp.a, 0, sizeof(tmp.a));
    tmp.a[10] = (LL)N;
    tmp.a[9] = 50000000;
    tmp.len = 11;
    memset(low.a, 0, sizeof(low.a));
    //  low = ln(N) * (N + 0.5)
    mul(mid, tmp, low);
 
    //  mid = ln(N) * (N + 0.5)
    mid = low;
 
    //  tmp = N
    memset(tmp.a, 0, sizeof(tmp.a));
    tmp.a[10] = (LL)N;
    tmp.len = 11;
 
    //  mid = ln(N) * (N + 0.5) - N
    minus2(mid, tmp, mid);
 
    //  tmp = ln(sqrt(2 * PI))
    memset(tmp.a, 0, sizeof(tmp.a));
    tmp.a[9] = 91893853;
    tmp.a[8] = 32046727;
    tmp.a[7] = 41780329;
    tmp.a[6] = 73640562;
    tmp.len = 10;
 
    //  mid = ln(N) * (N + 0.5) - N + ln(sqrt(2 * PI))
    //  Base Stirling's formula
    add(mid, tmp, mid);
 
    //  mid = Complete Stirling's series 
    //  See here: https://oeis.org/A046969
    memset(tmp.a, 0, sizeof(tmp.a));
    tmp.a[10] = 1;
    tmp.len = 11;
    div(tmp, 12);
    div(tmp, N);
    add(tmp, mid, mid);
 
    memset(tmp.a, 0, sizeof(tmp.a));
    tmp.a[10] = 1;
    tmp.len = 11;
    div(tmp, 360);
    for (i = 0; i < 3; i++)
        div(tmp, N);
    minus2(mid, tmp, mid);
 
    memset(tmp.a, 0, sizeof(tmp.a));
    tmp.a[10] = 1;
    tmp.len = 11;
    div(tmp, 1260);
    for (i = 0; i < 5; i++)
        div(tmp, N);
    add(mid, tmp, mid);
    //  NB!!!!!!!!!!!!!
 
    //  ten = ln(10)
    //  convert ln(N!) to log(N!) by dividing(using binary search instead) ln(10)
    ten.a[10] = 2;
    ten.a[9] = 30258509;
    ten.a[8] = 29940456;
    ten.a[7] = 84017991;
    ten.a[6] = 1304791;
    ten.a[5] = 80191566;
    ten.a[4] = 79210468;
    ten.a[3] = 4857633;
    ten.a[2] = 5615279;
    ten.a[1] = 78336811;
    ten.a[0] = 6567382;
    ten.len = 11;
    get_big_div();
 
    //  get the decimal (PURE) part of mid = log(N!)
    //  removing the tailing '0' of N! in DEC
    for (i = 10; i < LEN; i++)
        mid.a[i] = 0;
    for (i = 9; i >= 0 && mid.a[i] == 0; i--);
    mid.len = i + 1;
 
    //  convert PURE log(N!) to PURE ln(N)
    memset(power.a, 0, sizeof(power.a));
    mul(ten, mid, power);
 
    //  Taylor series of Exponential function
    memset(mm[0].a, 0, sizeof(mm[0].a));
    mm[0].a[10] = 1;
    mm[0].len = 11;
    tmp = mm[0];
    //  Since K won't be greater than 100, we just calculate the first 100 items
    for (i = 1; i <= 100; i++)
    {
        memset(mm[i].a, 0, sizeof(mm[i].a));
        mul(mm[i - 1], power, mm[i]);
        div(mm[i], i);
        add(mm[i], tmp, tmp);
    }
}
void f2()
{
    int i, j;
    LL tt = 1;
    LL ans = 1;
    for (i = 0; i < L; i++)
        tt *= 10;
    if (N > 1000)
    {
        for (i = 0; i < L; i++)
            printf("0");
        printf("\n");
        return;
    }
    int kk[300];
    int ii = 0;
    memset(kk, 0, sizeof(kk));
    for (i = 0; i < L / 8 + 2; i++)
    {
        tt = fac_n[N].a[i];
        for (j = 0; j < 8; j++)
            kk[ii++] = (int)(tt % 10), tt /= 10;
    }
    for (i = L - 1; i >= 0; i--)
        printf("%d", kk[i]);
    printf("\n");
}
void output(LL temp[], int l)
{
    int kk[100];
    int i, j;
    LL tt;
    int ii = 0;
    if (l - 8 <= 0)
        i = 0;
    else
        i = l - 8;
    for (; i < l - 1; i++)
    {
        tt = temp[i];
        for (j = 0; j < 8; j++)
            kk[ii++] = (int)(tt % 10), tt /= 10;
    }
    tt = temp[l - 1];
    while (tt)
        kk[ii++] = (int)(tt % 10), tt /= 10;
    for (i = ii - 1; i >= ii - K; i--)
        printf("%d", kk[i]);
    printf(" ");
}
void f3()
{
    int i;
    if (N <= 1)
    {
        for (i = fac_n[N].len - 1; i >= 0 && fac_n[N].a[i] == 0; i--);
        output(fac_n[N].a, i + 1);
        return;
    }
    f1();
    for (i = tmp.len; i >= 0 && tmp.a[i] == 0; i--);
    output(tmp.a, i + 1);
}
void init_bb()   //N<=1000,calculate all N!
{
    int i, j;
    for (i = 0; i < 1001; i++)
        memset(fac_n[i].a, 0, sizeof(fac_n[i].a));
    fac_n[1].a[0] = 1;
    fac_n[1].len = 1;
    for (i = 2; i < 1001; i++)
    {
        for (j = 0; j < fac_n[i - 1].len; j++)
            fac_n[i].a[j] = fac_n[i - 1].a[j] * (LL)i;
        for (j = 0; j < fac_n[i - 1].len; j++)
        {
            fac_n[i].a[j + 1] += fac_n[i].a[j] / BASE;
            fac_n[i].a[j] %= BASE;
        }
        fac_n[i].len = fac_n[i - 1].len;
        if (fac_n[i].a[fac_n[i - 1].len])
            fac_n[i].len++;
    }
}
int main()
{
    int T;
    init_bb();
    scanf("%d", &T);
    while (T--)
    {
        scanf("%d%d%d", &N, &K, &L);
        f3();
        f2();
    }
    return 0;
}
