namespace CSharpDataTypeChecker
{
    internal class clsNumberToStringConverter
    {
        // أهم التعديلات من C++ لـ C#:
        // - unsigned long long → ulong
        // - string arr[]{} → string[] arr = { };
        // - to_string() → ToString()
        // - 1'000'000 → 1_000_000
        // - ULL → UL
        // - C++ مفيهاش array بالشكل ده في C#، بنحدد النوع والحجم تلقائيًا بـ []
        // - باقي العمليات زي / و % والـ recursion تقريبًا زي ما هي.
        // - قسمت ConvertNumberToText لاتنين عشان أعرف أستخدم الأرقام السالبة
        // - استخدمت Method Overloading عشان أتعامل مع long و ulong بشكل منفصل.

        public static string ConvertNumberToText(long Number)
        {
            if (Number == 0) return "Zero";

            if (Number < 0)
            {
                // long.MinValue حالة خاصة لأن القيمة المطلقة أكبر من long.MaxValue
                if (Number == long.MinValue)
                {
                    return "Minus Nine Quintillion Two Hundred Twenty Three Quadrillion Three Hundred Seventy Two Trillion Thirty Six Billion Eight Hundred Fifty Four Million Seven Hundred Seventy Five Thousand Eight Hundred Eight";
                }

                return "Minus " + ConvertNumberToText(-Number);
            }

            if (Number >= 1 && Number < 20)
            {
                string[] arr = { "","One","Two","Three","Four","Five","Six","Seven",
            "Eight","Nine","Ten","Eleven","Twelve","Thirteen","Fourteen",
            "Fifteen","Sixteen","Seventeen","Eighteen","Nineteen" }
                ;
                return arr[Number];
            }

            if (Number >= 20 && Number < 100)
            {
                string[] arr = { "", "", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" }
                ;
                return arr[Number / 10] + (Number % 10 != 0 ? " " + ConvertNumberToText(Number % 10) : "");
            }

            if (Number >= 100 && Number < 1000)
            {
                return ConvertNumberToText(Number / 100) + " Hundred" + (Number % 100 != 0 ? " " + ConvertNumberToText(Number % 100) : "");
            }

            // Thousands: 1,000 to 999,999
            if (Number >= 1_000L && Number < 1_000_000L)
            {
                return ConvertNumberToText(Number / 1_000L) + " Thousand" + (Number % 1_000L != 0 ? " " + ConvertNumberToText(Number % 1_000L) : "");
            }

            // Millions: 1,000,000 to 999,999,999
            if (Number >= 1_000_000L && Number < 1_000_000_000L)
            {
                // Or: if (Number >= (unsigned long long)1e6 && Number < (unsigned long long)1e9)
                return ConvertNumberToText(Number / 1_000_000L) + " Million" + (Number % 1_000_000L != 0 ? " " + ConvertNumberToText(Number % 1_000_000L) : "");
            }

            // Billions: 1,000,000,000 to 999,999,999,999
            if (Number >= 1_000_000_000L && Number < 1_000_000_000_000L)
            {
                return ConvertNumberToText(Number / 1_000_000_000L) + " Billion" + (Number % 1_000_000_000L != 0 ? " " + ConvertNumberToText(Number % 1_000_000_000L) : "");
            }

            // Trillions: 1,000,000,000,000 to 999,999,999,999,999
            if (Number >= 1_000_000_000_000L && Number < 1_000_000_000_000_000L)
            {
                return ConvertNumberToText(Number / 1_000_000_000_000L) + " Trillion" + (Number % 1_000_000_000_000L != 0 ? " " + ConvertNumberToText(Number % 1_000_000_000_000L) : "");
            }

            // Quadrillions: 1,000,000,000,000,000 to 999,999,999,999,999,999
            if (Number >= 1_000_000_000_000_000L && Number < 1_000_000_000_000_000_000L)
            {
                return ConvertNumberToText(Number / 1_000_000_000_000_000L) + " Quadrillion" + (Number % 1_000_000_000_000_000L != 0 ? " " + ConvertNumberToText(Number % 1_000_000_000_000_000L) : "");
            }

            return "Out of range...";
        }


        public static string ConvertNumberToText(ulong Number)
        {
            // من 0 إلى long.MaxValue
            // نقدر نستفيد من نسخة long بدل تكرار الكود
            if (Number <= long.MaxValue)
                return ConvertNumberToText((long)Number);


            // Quadrillions: 1,000,000,000,000,000 to 999,999,999,999,999,999
            if (Number >= 1_000_000_000_000_000UL &&
                Number < 1_000_000_000_000_000_000UL)
            {
                return ConvertNumberToText(Number / 1_000_000_000_000_000UL) +
                    " Quadrillion" +
                    (Number % 1_000_000_000_000_000UL != 0
                        ? " " + ConvertNumberToText(Number % 1_000_000_000_000_000UL)
                        : "");
            }

            // Quintillions: 1,000,000,000,000,000,000 to 9,223,372,036,854,775,807 
            // unsigned long long int RealMaxNumber = 18'446'744'073'709'551'615UL;
            if (Number >= 1_000_000_000_000_000_000UL &&
                Number <= 18_446_744_073_709_551_615UL)
            {
                return ConvertNumberToText(Number / 1_000_000_000_000_000_000UL) +
                    " Quintillion" +
                    (Number % 1_000_000_000_000_000_000UL != 0
                        ? " " + ConvertNumberToText(Number % 1_000_000_000_000_000_000UL)
                        : "");
            }

            return "Out of range...";
        }


        public static string ConvertNumberTo1eNum(long number)
        {
            if (number == 0)
                return "0e0";

            bool isNegative = number < 0;

            if (number == long.MinValue)
                return "-9e18";

            if (isNegative)
                number = -number;

            byte count = 0;

            while (number >= 10)
            {
                number /= 10;
                count++;
            }

            return (isNegative ? "-" : "") + number + "e" + count;
        }


        public static string ConvertNumberTo1eNum(ulong number)
        {
            if (number == 0)
                return "0e0";

            byte count = 0;

            while (number >= 10)
            {
                number /= 10;
                count++;
            }

            return number.ToString() + "e" + count.ToString();
        }
    }
}


/*
 * Old C++ Code
 * 
#include <iostream>
#include <string>
#include <limits> // لضمان عمل numeric_limits بدون مشاكل

using namespace std;

unsigned long long ReadLongPositiveNumber(string Message = "Please enter a number: ") {
    unsigned long long Number = 0;
    do {
        cout << Message;
        cin >> Number;

        while (cin.fail()) // Validation
        {
            cin.clear();
            cin.ignore(numeric_limits<streamsize>::max(), '\n');

            cout << "Invalid Number, Enter a valid one : ";
            cin >> Number;
        }
    } while (Number <= 0);
    return Number;
}

string ConvertNumberToText(unsigned long long Number)
{
    // متنساش تستخدم unsigned long long ReadLongPositiveNumber()
    if (Number == 0) return "";

    if (Number >= 1 && Number < 20)
    {
        string arr[]{
            "","One","Two","Three","Four","Five","Six","Seven",
            "Eight","Nine","Ten","Eleven","Twelve","Thirteen","Fourteen",
            "Fifteen","Sixteen","Seventeen","Eighteen","Nineteen" };
        return arr[Number];
    }

    if (Number >= 20 && Number < 100)
    {
        string arr[]{
            "","","Twenty","Thirty","Forty","Fifty","Sixty","Seventy","Eighty","Ninety" };
        return arr[Number / 10] + (Number % 10 != 0 ? " " + ConvertNumberToText(Number % 10) : "");
    }

    if (Number >= 100 && Number < 1000)
    {
        return ConvertNumberToText(Number / 100) + " Hundred" + (Number % 100 != 0 ? " " + ConvertNumberToText(Number % 100) : "");
    }

    // Thousands: 1,000 to 999,999
    if (Number >= 1'000ULL && Number < 1'000'000ULL) //(unsigned long long)1000000
    {
        return ConvertNumberToText(Number / 1'000ULL) + " Thousand" + (Number % 1'000ULL != 0 ? " " + ConvertNumberToText(Number % 1'000ULL) : "");
    }

    // Millions: 1,000,000 to 999,999,999
    if (Number >= 1'000'000ULL && Number < 1'000'000'000ULL)
    {
// Or: if (Number >= (unsigned long long)1e6 && Number < (unsigned long long)1e9)
        return ConvertNumberToText(Number / 1'000'000ULL) + " Million" + (Number % 1'000'000ULL != 0 ? " " + ConvertNumberToText(Number % 1'000'000ULL) : "");
    }

    // Billions: 1,000,000,000 to 999,999,999,999
    if (Number >= 1'000'000'000ULL && Number < 1'000'000'000'000ULL)
    {
        return ConvertNumberToText(Number / 1'000'000'000ULL) + " Billion" + (Number % 1'000'000'000ULL != 0 ? " " + ConvertNumberToText(Number % 1'000'000'000ULL) : "");
    }

    // Trillions: 1,000,000,000,000 to 999,999,999,999,999
    if (Number >= 1'000'000'000'000ULL && Number < 1'000'000'000'000'000ULL)
    {
        return ConvertNumberToText(Number / 1'000'000'000'000ULL) + " Trillion" + (Number % 1'000'000'000'000ULL != 0 ? " " + ConvertNumberToText(Number % 1'000'000'000'000ULL) : "");
    }

    // Quadrillions: 1,000,000,000,000,000 to 999,999,999,999,999,999
    if (Number >= 1'000'000'000'000'000ULL && Number < 1'000'000'000'000'000'000ULL)
    {
        return ConvertNumberToText(Number / 1'000'000'000'000'000ULL) + " Quadrillion" + (Number % 1'000'000'000'000'000ULL != 0 ? " " + ConvertNumberToText(Number % 1'000'000'000'000'000ULL) : "");
    }

    // Quintillions: 1,000,000,000,000,000,000 to 9,223,372,036,854,775,807 
   // unsigned long long int RealMaxNumber = 18'446'744'073'709'551'615ULL;
    if (Number >= 1'000'000'000'000'000'000ULL && Number <= 18'446'744'073'709'551'615ULL)
    {
        return ConvertNumberToText(Number / 1'000'000'000'000'000'000ULL) + " Quintillion" + (Number % 1'000'000'000'000'000'000ULL != 0 ? " " + ConvertNumberToText(Number % 1'000'000'000'000'000'000ULL) : "");
    }

    return "Out of range...";
}

string ConvertNumberTo1eNum(unsigned long long number)
{
    if (number == 0) return "0e0";
    short count = 0;

    while (number >= 10)
    {
        number /= 10;
        count++;
    }
    return to_string(number) + "e" + to_string(count);
}

int main()
{
    // cout << LLONG_MAX; // 9,223,372,036,854,775,807 
    unsigned long long int RealMaxNumber = 18'446'744'073'709'551'615ULL;
    unsigned long long int Number = ReadLongPositiveNumber();
   
    if (Number == 0) {
        cout << "Zero" << endl;
    }
    else {
        cout << ConvertNumberToText(Number) << endl;
    }

    cout << ConvertNumberTo1eNum(Number) << endl;
   
    
  //      cout << ConvertNumberToText(RealMaxNumber) << endl;
   // cout << ConvertNumberTo1eNum(RealMaxNumber) << endl;

    return 0;
}
*
**
**
*/
