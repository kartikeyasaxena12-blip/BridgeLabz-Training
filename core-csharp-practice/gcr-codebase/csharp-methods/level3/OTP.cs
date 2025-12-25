using System;
class OTP
{
    public static int GenerateOTP()//otp generate
    {
        Random random = new Random();
        return random.Next(100000, 1000000);
    }

    public static bool AreOTPsUnique(int[] otps)
    {
        for (int i = 0; i < otps.Length; i++)
        {
            for (int j = i + 1; j < otps.Length; j++)
            {
                if (otps[i] == otps[j])
                    return false;
            }
        }
        return true;
    }

    static void Main()
    {
        int[] otps = new int[10];

        Console.WriteLine("Generating OTPs:");
        for (int i = 0; i < 10; i++)
        {
            otps[i] = GenerateOTP();
            Console.WriteLine("OTP " + (i + 1) + ": " + otps[i]);
        }

        bool unique = AreOTPsUnique(otps);
        Console.WriteLine("\nAre all OTPs unique? " + (unique ? "Yes" : "No"));
    }
}
