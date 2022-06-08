using System;

namespace Algorithms.RomanNum
{
    /*
        Create a function taking a positive integer as its parameter and returning a string containing the Roman Numeral representation of that integer.
        Modern Roman numerals are written by expressing each digit separately starting with the left most digit and skipping any digit with a value of zero. 
        In Roman numerals 1990 is rendered: 1000=M, 900=CM, 90=XC; resulting in MCMXC. 2008 is written as 2000=MM, 8=VIII; or MMVIII. 1666 uses each Roman symbol in descending order: MDCLXVI.
    */
    public class WriteRomanNumerals
    {
        public static string Numerals(int num)
        {
            string result = string.Empty;

            if (num < 0 && num > 4000)
            {
                return result;
            }

            string size = num.ToString();

            int n = size.Length - 1;

            foreach (var item in size)
            {
                string number = item.ToString();

                if (!Int32.TryParse(number, out int res)) return "";

                int value = (int)(res * Math.Pow(10, n));

                switch (n)
                {
                    case 0:
                        result += Unit(value);
                        break;
                    case 1:
                        result += Tens(value);
                        break;
                    case 2:
                        result += Hundreds(value);
                        break;
                    case 3:
                        result += PrimaryAppender(value);
                        break;
                    default:
                        break;
                }
                n--;
            }

            return result;
        }
      
        static string Hundreds(int num)
        {
            string result = string.Empty;

            if (num < 10) return result;

            if (num <= 300)
            {
                result += PrimaryAppender(num);
            }
            else if (num == 400)
            {
                return "CD";
            }
            else if (num == 500)
            {
                return "D";
            }
            else if (num == 900)
            {
                return "CM";
            }
            else
            {
                num = num - 500;
                result = "D";
                result += PrimaryAppender(num);
            }

            return result;

        }

        static string Tens(int num)
        {
            string result = string.Empty;

            if (num < 10) return result;

            if (num <= 30)
            {
                result += PrimaryAppender(num);
            }
            else if (num == 40)
            {
                return "XL";
            }
            else if (num == 50)
            {
                return "L";
            }
            else if (num == 90)
            {
                return "XC";
            }
            else
            {
                num = num - 50;
                result = "L";
                result += PrimaryAppender(num);
            }

            return result;

        }

        static string Unit(int num)
        {
            string result = string.Empty;

            if (num <= 0 && num > 10) return result;

            if (num <= 3)
            {
                return PrimaryAppender(num);
            }
            else if (num == 4)
            {
                return "IV";
            }
            else if (num == 5)
            {
                return "V";
            }
            else if (num == 9)
            {
                return "IX";
            }
            else
            {
                num = num - 5;
                result = "V";
                result += PrimaryAppender(num);
            }

            return result;
        }

        static string PrimaryAppender(int num)
        {
            string result = string.Empty;

            if (num <= 0) return result;

            string symbol = string.Empty;
            int loopControl = num;

            if (num >= 1 && num <= 3)
            {
                symbol = "I";
            }

            if (num >= 10 && num <= 30)
            {
                symbol = "X";
                loopControl /= 10;
            }

            if (num >= 100 && num <= 300)
            {
                symbol = "C";
                loopControl /= 100;
            }

            if (num >= 1000 && num <= 3000)
            {
                symbol = "M";
                loopControl /= 1000;
            }



            while (loopControl > 0)
            {
                result += symbol;
                loopControl--;
            }

            return result;
        }

    }


    /*
        Create a function that takes a Roman numeral as its argument and returns its value as a numeric decimal integer. You don't need to validate the form of the Roman numeral.
        Modern Roman numerals are written by expressing each decimal digit of the number to be encoded separately, starting with the leftmost digit and skipping any 0s. 
        So 1990 is rendered "MCMXC" (1000 = M, 900 = CM, 90 = XC) and 2008 is rendered "MMVIII" (2000 = MM, 8 = VIII). The Roman numeral for 1666, "MDCLXVI", uses each letter in descending order.
    */
    public class ReadRomanNumerals
    {
        public static int Decode(string roman)
        {

            int result = 0;

            for(int i = 0; i < roman.Length; i++)
            {
                int specialCase = 0;

                if((i+1)<=(roman.Length-1)) specialCase = SpecialCase(roman[i], roman[i+1]);
                
                if(specialCase == 0)
                {
                    result += ExtraPrimaryFigure(roman[i]);
                }
                else
                {
                    result += specialCase;
                    i++;
                }
            }

            return result;
        }

        static int SpecialCase(char firstNumeral, char secondNumeral)
        {
            int figure = 0;

            //Units
            if(firstNumeral=='I' && secondNumeral =='V') figure = 4;
            if(firstNumeral=='V' && secondNumeral =='I') figure = 6;
            if(firstNumeral=='I' && secondNumeral =='X') figure = 9;

            //Tens
            if(firstNumeral=='X' && secondNumeral =='L') figure = 40;
            if(firstNumeral=='L' && secondNumeral =='X') figure = 60;
            if(firstNumeral=='X' && secondNumeral =='C') figure = 90;

            //Hundreds
            if(firstNumeral=='C' && secondNumeral =='D') figure = 400;
            if(firstNumeral=='D' && secondNumeral =='C') figure = 600;
            if(firstNumeral=='C' && secondNumeral =='M') figure = 900;

            return figure;
        }

        static int ExtraPrimaryFigure(char numeral)
        {
            int figure = 0;

            if (numeral.Equals(null)) return figure;

            switch(numeral)
            {
                case 'I':
                    figure = 1;
                    break;
                case 'V':
                    figure = 5;
                    break;
                case 'X':
                    figure = 10;
                    break;
                case 'L':
                    figure = 50;
                    break;
                case 'C':
                    figure = 100;
                    break;
                case 'D':
                    figure = 500;
                    break;
                case 'M':
                    figure = 1000;
                    break;
                default:
                    break;
            }

            return figure;
        }

    }
}